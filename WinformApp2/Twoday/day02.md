---
typora-copy-images-to: assets
---

# day02

## 一、上节回顾

### winform

> 是windows form的简称,  窗体应用 客户端

### 控件

> 组成界面的最小单元

- Button

- Label

- TextBox

- CheckBox

- RadioButton

- ComboBox

- ListBox

- richTextBox

- DateTimePicker

- PictureBox

- LinkLable

  

## 二、容器和控件

### 1、概念

winform界面由都是由控件组成的。但有些控件需要进行分组管理，才好操作，例如单选框，如果一个界面中需要多组单选框，我们都放在Form这个窗体（控件）中，就会让所有单选按钮都互斥，无法实现分组的效果。

例：

![](D:/%E8%A7%86%E8%A7%8902/02-WinForm%E9%98%B6%E6%AE%B5/01day/01-%E8%AF%BE%E4%BB%B6/01day/assets/%E5%8D%95%E9%80%89%E6%8C%89%E9%92%AE%E4%BA%92%E6%96%A5.gif) 

为了能实现分组，winform将控件分为两类，一类是**普通控件**，也就是我们上面学习的，另一类是**容器控件**，就像Form控件，可以在里面装普通控件，达到分组管理的目的。也就是说winform界面是由控件之间互相嵌套形成的。Form属于**根容器**，里面可以放在普通控件，也可以放其他容器。容器也是可以嵌套容器的。



容器控件又分为两种，一种是**能控制子控件布局**的容器，另一种是**不能控制子控件布局**的。

能控制子控件自动布局的容器，我们又称为**布局容器**。不能控制子控件布局的容器，我们叫做**简单容器**。

### 2、简单容器

简单容器只提供存放区域，不自动布局，所以不会控制子控件的布局方式，子控件的布局方式由子控件自己的属性操作，例如：`Location`、`Size`、`Anchor`、`Dock`等，子控件设置后，就生效，不会被父容器的布局方式所忽略。

#### 2.1、Form

**窗体根容器**：

- `Text`：窗体标题
- `MaximizeBox `：是否显示最大化按钮
- `MinimizeBox`：是否显示最小化按钮
- `StartPosition `：启动后窗体显示的位置
  - Manual：窗体的位置由 `Location` 属性决定；如果不设置 Location，默认出现在屏幕左上角 (0,0)。
  - CenterScreen：屏幕中央。
  - WindowsDefaultLocation：系统决定窗体初始位置，大小由 Size 决定；一般出现在屏幕左上角区域，由 Windows 窗口管理器分配。
  - WindowsDefaultBounds：Windows 默认边界。系统不仅决定位置，连窗体的 Size 大小也由系统决定，代码设置的 Size 会被忽略。
  - CenterParent: 父窗体中央。窗体出现在它父窗体的中间。多用于子弹窗、对话框；如果是主窗体（没有父窗体），效果相当于 `CenterScreen`）

#### 2.2、Panel

**面板容器**控件。最基础的容器，默认无边框、无标题。它本身不包含自动排列逻辑，但支持所有手动和自动布局属性（`Dock`, `Anchor`, `AutoSize`）。通常用于分组，让内部的子控件跟外部不产生自动的关联。

属性：

- `AutoScroll`：（当子控件超出面板范围时，自动显示滚动条）。
- `Dock`：紧贴父容器边缘，另一个方向拉伸至父容器大小。
  - Top：控件上边紧贴父容器上边；宽度自动填满父容器的整个宽度；高度自己设定。
  - Bottom：下边紧贴父容器下边；宽度填满父容器；高度自己设定。
  - Left：左边紧贴父容器左边；高度填满父容器全部高度；宽度自己设定。
  - Right：右边紧贴父容器右边；高度填满父容器全部高度；宽度自己设定。
  - Fill：上下左右全部贴住父容器四边，宽高完全占满父容器剩下的区域。
- `Anchor`：将当前控件固定在父容器指定的位置，且随着父容器大小改变时，当前控件会跟着拉伸大小改变。（如果父容器设置了Dock，拉伸大小不会改变）
  - Top,Left：窗口放大缩小，控件大小不变，只会呆在左上角不动。
  - Top,Left,Right：窗口横向拉大，控件宽度自动跟着变宽；高度不变。
  - Top,Left,Bottom：窗口高度变化，控件高度自动拉伸；宽度不变。
  - Top,Left,Right,Bottom：窗体放大，控件宽高同时跟着拉伸，填满父容器。效果类似 Dock.Fill，但不会贴死边缘，会保留边距。
  - Bottom,Right：窗口拉大，控件始终待在右下角，适合【确定 / 取消】按钮。
- `AutoSize`：自动大小。控件根据自己内容，自动调整自身的大小，把内容刚好包住。

注意：Anchor 不能和 Dock 同时生效：只要设置 Dock，Anchor 会被忽略。**Dock 优先级高于 Anchor**。如果只写 `Anchor = Bottom`，没有写 Top，控件会垂直移动，而不是拉伸。

#### 2.3、GroupBox

分组框容器控件。功能与 `Panel` 类似，但自带边框和标题（`Text` 属性）。主要用于在视觉上对功能模块进行分组，增强界面的层次感。没有滚动条。

#### 2.4、TabControl

**选项卡容器**。可以在同一个位置出现多个容器，点击标题可以切换容器展示。

属性：

- `TabPages`：集合，可以添加删除选项卡。
- `Multiline`：`true`：标签文字多行显示。标签很多的时候，标签会折成多行；false 只能单行，出现滚动小箭头。
- `Alignment`：标签摆放位置：Top 顶部 (默认)、Bottom 底部、Left 左侧、Right 右侧。标签可以放到上下左右四边。
- `ShowToolTips`：是否显示 TabPage 的 ToolTip 提示。

### 3、布局容器

布局容器的内部子控件尽量不要手动设置 Location，会失效，由布局容器规则控制。

#### 3.1、FlowLayoutPanel

**流式布局面板**。内部子控件像水流一样，按照指定的方向（水平或垂直）自动排列。当一行/一列的空间不够时，会自动换行/换列。

属性：

- `FlowDirection`（流向）
- `WrapContents`（是否允许换行）。
- `Padding`：容器内部边距，所有控件距离容器四边留出空隙。

FlowLayoutPanel 内部的子控件，Anchor 会失效。Flow 布局会接管子控件位置，子控件的 Anchor 不起作用。Dock 对子控件同样无效。

#### 3.2、TableLayoutPanel

**表格布局面板**。以行和列组成的网格形式排列控件，支持单元格合并（`ColumnSpan`, `RowSpan`）。

属性：

- `RowStyles` 和 `ColumnStyles`（可设置绝对像素值、百分比或自适应大小）。
- 若要合并单元格，需要给子控件设置合并，设置Dock才能看到效果。

#### 3.3、SplitContainer

**分割面板**。自带一个可拖动的分割条，将容器分为两个独立的面板（`Panel1` 和 `Panel2`）。

属性：

- `Orientation`（分割条方向）
- `SplitterDistance`（分割条位置）
- `SplitterWidth`：分割条本身的粗细像素，默认 4。
- `Panel1MinSize`：Panel1 允许的最小尺寸
- `Panel2MinSize`：Panel2 允许的最小尺寸
- `IsSplitterFixed`：固定分割条，用户不能拖动，只能代码改 分割条位置
- `Panel1Collapsed / Panel2Collapsed`：折叠面板
- `FixedPanel`（调整大小时哪个面板保持固定）



在实际开发中，极少只使用单一容器，**嵌套**才是王道：

- **组合案例**：使用 `SplitContainer` 作为窗体最外层框架 -> 左侧 `Panel1` 放入 `TreeView` -> 右侧 `Panel2` 放入 `TabControl` -> 某个 `TabPage` 内部再放入 `TableLayoutPanel` 来规整表单。
- **注意事项**：`TableLayoutPanel` 的每个单元格默认只能放一个控件。如果你需要在某个单元格里放多个控件，**必须**先在该单元格里拖入一个 `Panel` 或 `FlowLayoutPanel`，然后再往里面添加控件。





## 三、代码操作控件

### 1、示例

通过拖拽控件，我们会看到对应的代码。所以，我们完全可以单纯使用代码操作控件，例如：创建控件、操作控件排列等。

每个控件的名称就是代码中控件的类，所以创建控件就是实例化类得到对象：

```c#
// 实例化同时给属性赋值
Button MyBtn1 = new Button()
{
    Location = new Point(200, 200),
    Size = new Size(200, 50),
    Text = "确定"
};
// 实例化后，再给对象属性赋值
Button MyBtn2 = new Button();
MyBtn2.Location = new Point(500, 200);
MyBtn2.Size = new Size(200, 50);
MyBtn2.Text = "取消";
```

创建好的控件，不会自动出现在窗体中，需要手动添加。**容器控件**都有一个属性`Controls`（普通控件是没有的），可以对容器控件中的子控件进行增删操作。

容器中添加控件语法：

```c#
容器.Controls.Add(子控件);
```

例：

```c#
Button MyBtn1 = new Button()
{
    Location = new Point(200, 200),
    Size = new Size(200, 50),
    Text = "确定"
};
this.Controls.Add(MyBtn1);
```

若要放在Panel中，也可以用这个方法：

```c#
Panel panel1 = new Panel();
panel1.Location = new Point(351, 98);
panel1.Name = "panel1";
panel1.Size = new Size(300, 100);

Button MyBtn2 = new Button();
MyBtn2.Location = new Point(20, 20);
MyBtn2.Size = new Size(100, 50);
MyBtn2.Text = "取消";

panel1.Controls.Add(MyBtn2);
```

![1786267337895](assets/1786267337895.png) 

注意：1个控件只能同时有一个父容器。

### 2、Controls方法

容器控件的Controls除了有Add方法外，还有批量添加、删除等方法：

- AddRange：给容器中批量新增控件

  ```c#
  public void AddRange(Control[] controls)
  ```

  例：

  ```c#
  Button btn1 = new Button();
  Button btn2 = new Button();
  Label lab1 = new Label();
  
  // 批量数组
  Control[] ctrls = { btn1, btn2, lab1 };
  panel1.Controls.AddRange(ctrls);
  ```

  Control属于所有控件的基类，所以可以用Control类型存储控件。

- Remove ：从容器中删除指定的控件

  ```c#
  public void Remove(Control value);
  ```

  

- RemoveAt ：根据下标删除指定的控件

  ```c#
  public void RemoveAt(int index);
  ```

  

- Clear：清空容器中的控件

  ```c#
  public void Clear();
  ```

  

- SetChildIndex：修改控件的下标

  ```c#
  public void SetChildIndex(Control child, int newIndex);
  ```

- GetChildIndex：获取控件的下标

- Contains：判断容器中是否包含某个控件

  ```c#
  public bool Contains(Control ctl);
  ```

  

- IndexOf：查找控件在容器中的下标

  ```c#
  public int IndexOf(Control child);
  ```

  

除了方法，Controls也有一些属性：

```c#
panel1.Controls.Count;        // 获取子控件总数量
panel1.Controls[0];           // 通过索引获取子控件
panel1.Controls["button1"];   // 通过控件Name查找控件（字符串索引）
控件.Parent					// 获取控件的父容器，Form的父容器是null
```



## 四、事件

### 1、概念

为了能让用户跟界面之间产生交互效果，每个控件都有属于自己的事件。

也就是说，事件指的是用户跟控件之间的交互逻辑。

要实现一个事件的交互效果，需要有3个要素：事件源、事件类型、事件处理程序

事件源：代表用户当前在跟哪个控件交互，也就是控件

事件类型：代表用户的行为类型，例如：点击、改变状态等

事件处理程序：代表用户行为产生后，要执行的代码逻辑，也就是函数（类的方法）

### 2、语法

事件绑定的语法：

```c#
控件.事件类型 += 处理行为逻辑的方法
```

例：

```c#
MyBtn2.Click += MyBtn2_Click;

private void MyBtn2_Click(object sender, EventArgs e) 
// sender代表触发事件的控件
// e事件参数对象，携带本次事件附带的数据
{
    MyBtn2.BackColor = Color.Red;
}
```

事件类型，在属性窗口的闪电图标内：

![1786275465087](assets/1786275465087.png) 

> 输出内容：
>
> ```c#
> 结果 = MessageBox.Show(提示信息, 标题, 按钮类型MessageBoxButtons.YesNoCancle,  图标MessageBoxIcon.Question);
> 结果 == DialogResult.Yes; //  确认
> ```
>
> 

### 3、常用事件

#### 通用事件

几乎所有控件都有：Button、Label、TextBox、Panel、Form 等

| 事件         | 触发时机                 | 使用场景               |
| ------------ | ------------------------ | ---------------------- |
| `Click`      | 鼠标左键单击控件         | 按钮点击、普通单击逻辑 |
| `MouseDown`  | 鼠标按下（左右键都可以） | 拖拽、捕获鼠标按键     |
| `MouseUp`    | 鼠标松开                 | 拖拽结束               |
| `MouseMove`  | 鼠标在控件上移动         | 获取鼠标坐标、悬浮效果 |
| `MouseEnter` | 鼠标进入控件区域         | 鼠标悬浮变色           |
| `MouseLeave` | 鼠标离开控件区域         | 取消悬浮效果           |
| `KeyDown`    | 键盘按下（控件获得焦点） | 捕获快捷键             |
| `KeyPress`   | 按下字符键（字符输入）   | 过滤非法字符           |
| `KeyUp`      | 键盘松开                 |                        |
| `GotFocus`   | 控件获得焦点             | 文本框选中提示文字     |
| `LostFocus`  | 控件失去焦点             | 输入完成校验数据       |

#### TextBox

| 事件           | 说明                                   | 场景                           |
| -------------- | -------------------------------------- | ------------------------------ |
| `TextChanged`⭐ | 文本内容发生变化，每输入一个字符就触发 | 实时统计输入字数、实时过滤内容 |

#### ComboBox

| 事件                    | 说明           | 场景                       |
| ----------------------- | -------------- | -------------------------- |
| `SelectedIndexChanged`⭐ | 选中项发生改变 | 选择下拉选项，联动加载数据 |
| `TextChanged`           | 下拉框文本改变 | 可编辑模式输入文字         |

只要索引变了就触发，初始化绑定数据的时候也会触发一次。

#### ListBox

| 事件                    | 说明       |                |
| ----------------------- | ---------- | -------------- |
| `SelectedIndexChanged`⭐ | 切换选中行 | 选中行读取数据 |

#### 输入类控件

| 事件         | 作用                       | 参数            | 新手接触度                  |
| ------------ | -------------------------- | --------------- | --------------------------- |
| `GotFocus`   | 控件拿到焦点               | EventArgs       | ⭐⭐⭐⭐⭐（高频）               |
| `Validating` | **将要失去焦点，校验数据** | CancelEventArgs | ⭐⭐⭐（进阶，表单开发强推荐） |
| `Validated`  | 校验成功之后触发           | EventArgs       | ⭐⭐                          |
| `Leave`      | 控件真正失去焦点           | EventArgs       | ⭐⭐⭐⭐⭐（高频）               |

事件真实执行顺序（完整链条）：`GotFocus` → 用户操作 → `Validating`（校验） →` Validated`（校验成功） → `Leave`

### 4、事件参数对象

#### 鼠标事件：MouseEventArgs

| 属性         | 说明                                                       |
| ------------ | ---------------------------------------------------------- |
| `e.X`        | 鼠标相对于控件客户区的 X 坐标                              |
| `e.Y`        | 鼠标相对于控件客户区的 Y 坐标                              |
| `e.Location` | `Point`类型，等价 new Point (e.X,e.Y)                      |
| `e.Button`   | 获取哪个鼠标按键：`MouseButtons.Left` / `Right` / `Middle` |
| `e.Clicks`   | 点击次数，单击 = 1，双击 = 2                               |
| `e.Delta`    | 鼠标滚轮滚动数值（滚轮上下）                               |

#### 键盘事件：KeyEventArgs

| 属性                 | 说明                                                         |
| -------------------- | ------------------------------------------------------------ |
| `e.KeyCode`          | Keys 枚举，获取按下的物理按键（`Keys.Enter`、`Keys.Escape`、`Keys.F1`）⭐ |
| `e.Control`          | bool，是否按住 Ctrl 键⭐                                      |
| `e.Shift`            | bool，是否按住 Shift 键⭐                                     |
| `e.Alt`              | bool，是否按住 Alt 键⭐                                       |
| `e.Handled`          | bool，设置 true 可以**取消本次按键处理**                     |
| `e.SuppressKeyPress` | bool，抑制按键字符输入，比 Handled 更强                      |

#### KeyPress 事件：KeyPressEventArgs

| 属性        | 说明                                                   |
| ----------- | ------------------------------------------------------ |
| `e.KeyChar` | char，获取按下的字符，例如`'0'`、`'A'`、退格`(char)8`⭐ |
| `e.Handled` | bool，**设置 true 拦截本次输入，字符不会进到文本框**⭐  |

#### 窗体正在关闭：FormClosingEventArgs

| 属性            | 说明                                             |
| --------------- | ------------------------------------------------ |
| `e.Cancel`      | bool，设置`true`，**取消关闭窗体，窗体不退出**⭐  |
| `e.CloseReason` | 枚举，关闭原因：用户点 X、代码 Close、系统关机等 |

#### 校验事件：CancelEventArgs

| 属性       | 说明                                                      |
| ---------- | --------------------------------------------------------- |
| `e.Cancel` | bool，`true`阻止焦点离开控件⭐，不用手动 Focus，避免死循环 |

### 5、案例

开灯关灯案例（Click）：

```c#
private void Button1_Click(object sender, EventArgs e)
{
    Button btn = (Button)sender;
    // 判断按钮中的文本内容
    if (btn.Text == "打开") {
        // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
        pictureBox1.Image = Image.FromFile(@"./images/on.png");
        btn.Text = "关闭";
    }
    else
    {
        pictureBox1.Image = Image.FromFile(@"./images/off.png");
        btn.Text = "打开";
    }
}
```

![](assets/开关灯.gif) 

选项卡（Click）：

```c#
 public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
 public void initTab() {
     
     // 设置初始值
     pictureBox1.Image = Image.FromFile(picArr[0]);
     panel1.Controls[0].BackColor = Color.Cyan;
     panel1.Controls[0].ForeColor = Color.White;

     // 绑定事件
     for (int i = 0; i < panel1.Controls.Count; i++)
     {
         panel1.Controls[i].Click += btn_Click;

     }
 }
 public void btn_Click(object sender,EventArgs e) // 事件函数
 {
     // 先将所有的按钮的高亮效果移除
     for (int i = 0; i < panel1.Controls.Count; i++)
     {
         panel1.Controls[i].BackColor = Color.DarkGray; 
         panel1.Controls[i].ForeColor = Color.Black;
     }
     // 将当前这个按钮的高亮添加
     Button btn = (Button)sender;
     btn.BackColor = Color.Cyan;
     btn.ForeColor = Color.White;

     // 修改图片地址: 当前按钮和对应的图片地址的索引一致
     // 获取 btn按钮在容器中的下标
     int index = panel1.Controls.IndexOf(btn);

     pictureBox1.Image = Image.FromFile(picArr[index]);
 }
```

![](assets/选项卡.gif) 





