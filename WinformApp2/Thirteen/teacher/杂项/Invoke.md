##  Invoke

## 一、委托的 `Invoke` 详解

### 1. 本质与生成机制

- 委托类型是编译器生成的类，继承自 `System.MulticastDelegate`，而 `MulticastDelegate` 继承自 `System.Delegate`。
- 委托类型中包含三个核心方法：`Invoke`、`BeginInvoke`、`EndInvoke`（后两者用于异步调用，现已较少使用）。
- `Invoke` 方法的签名与委托声明完全一致（参数类型、个数、返回值类型）。
- 当我们写 `del(args)` 时，C# 编译器将其翻译为 `del.Invoke(args)`，这只是语法糖。



### 2. 参数与返回值

- **参数**：与委托声明中的参数列表完全相同，包括 `ref`、`out` 修饰符（但极少在委托中使用）。
- **返回值**：与委托声明中的返回类型一致，如果没有返回值则为 `void`。
- **多播委托**：如果委托链中包含多个方法，`Invoke` 会按顺序调用每个方法。对于有返回值的委托，只有最后一个方法的返回值会被返回；如果委托链中有方法抛出异常，后续方法不会执行。



### 3. 使用场景

- 显式调用委托，提高代码意图清晰度。
- 在需要通过 `Delegate` 基类引用委托并调用时（如事件内部触发）。
- 多播委托的链式调用，例如日志系统同时输出到多个目标。

**示例**：多播委托

```csharp
public delegate void LogHandler(string msg);
LogHandler log = Console.WriteLine;
log += msg => File.AppendAllText("log.txt", msg + "\n");

log.Invoke("测试消息"); // 依次执行 Console.WriteLine 和文件写入
```





## 二、`控件.Invoke` 

### 1. 所属与作用

- 定义在 `System.Windows.Forms.Control` 类中，所有控件（包括窗体）继承此方法。
- 目的：解决 WinForms 控件的线程亲和性问题——控件只能在创建它的 UI 线程上访问。其他线程必须通过 `Invoke`/`BeginInvoke` 将委托封送到 UI 线程执行。

>在 **.NET Core 3.0 及更高版本** 中，Windows Forms 的 `Control.CheckForIllegalCrossThreadCalls` 属性**默认被设置为 false**，因此运行时**不再主动检查并抛出跨线程异常**，而是允许直接访问控件。
>
>**.NET Core / .NET 5+**（比如 .NET 6、7、8），而不是传统的 .NET Framework。
>
>```C#
>// 可以在构造函数中设置模拟 .NET Framework
>// 开启跨线程调用检查（默认在 .NET Core 中为 false）
>Control.CheckForIllegalCrossThreadCalls = true;
>```



### 2. 方法签名（重载）

**`Invoke` 同步执行**
```csharp
public object Invoke(Delegate method);
public object Invoke(Delegate method, params object[] args);
```



### 3. 返回值

- `Invoke` 返回 `object`：委托方法的返回值（如果有）。如果委托返回 `void`，则返回 `null`。需要手动拆箱为具体类型。



### 4. `InvokeRequired` 属性

- 定义在 `Control` 类中，类型为 `bool`。
- 如果当前线程不是创建控件的线程，则返回 `true`；否则返回 `false`。
- 使用模式：
  ```csharp
  if (control.InvokeRequired)
      control.Invoke(...);
  else
      // 直接操作控件
  ```
- 内部实现：通过比较当前线程 ID 与创建控件的线程 ID 来判断。



### 5.Invoke 具体使用

```C#
// 判断当前线程是否为主 UI 线程
if (label1.InvokeRequired)
{
    // 不是主线程    用 Invoke 封送到主线程执行
    label1.Invoke(new Action(() => label1.Text = text));
}
else
{
    // 已经是主线程   直接修改
    label1.Text = text;
}

```

