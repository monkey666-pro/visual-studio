# WinForm Settings 


## Settings

### Settings 到底是什么？

> Settings 是 WinForm 内置的配置，帮你记住程序运行时需要的数据。

### 两种作用域（Scope）

| 作用域          | 读写权限       | 存哪          | 典型用途                                   |
| :-------------- | :------------- | :------------ | :----------------------------------------- |
| **Application** | 只能读，不能写 | `exe.config`  | 数据库连接串、API 地址（所有人都一样）     |
| **User**        | 既能读，也能写 | `user.config` | 记住密码、窗口大小、主题颜色（每人不一样） |

> 凡是跟“当前用户偏好”相关的，一律用 **User**；凡是“所有人都必须用同一个值”的，用 **Application**。

### 

## Settings 操作

> 核心对象：`Properties.Settings.Default`

### 1. 读数据

> 程序启动时，把存过的用户名、密码、复选框状态拿出来用。

```csharp
// 写法1：直接读（最常用）
string username = Properties.Settings.Default.Username;
bool rememberMe = Properties.Settings.Default.RememberMe;

// 写法2：用索引器
string password = Properties.Settings.Default["Password"].ToString();  // 读出来是 object，要转类型
```

> `Default` 点后面的名字就是你之前定义好的配置项，和用变量一样简单。



### 2. 写入

> 用户登录成功了，把当前输入的账号密码存进去。

```csharp
// 直接赋值
Properties.Settings.Default.Username = txtUsername.Text.Trim();
Properties.Settings.Default.Password = txtPassword.Text;
Properties.Settings.Default.RememberMe = chkRememberMe.Checked;
```

> **注意**：这里赋值完，数据**只存在内存里**，程序一关就丢了。



### 3. 保存

> 赋值完了，要真正存到硬盘上的 `user.config` 文件里。(持久化)

```csharp
// 持久化
Properties.Settings.Default.Save();
```



### 4. 重置

> 用户点了“清除记录”，或者你想在测试时把所有用户配置清掉。

```csharp
// 把所有 User 作用域的设置恢复成你在 Settings.settings 里填的默认值
Properties.Settings.Default.Reset();
```

> 相当于把 `user.config` 文件内容删了，下次启动程序会从 `App.config` 重新读默认值。