---
typora-copy-images-to: assets
---

# day01

## 一、winform介绍 

### 1、概念

WinForm，全称为 Windows Form，是基于 .NET Framework 平台的客户端开发技术，主要用于创建桌面应用程序。WinForm 应用程序通常使用 C# 编程语言进行开发，并且与 Windows 操作系统的界面风格相似，提供了丰富的控件和事件，使得开发者能够快速上手并高效地构建应用程序。

### 2、WinForm 的特点

WinForm 支持可视化设计，允许开发者通过拖拽控件的方式来设计用户界面，这大大简化了界面的构建过程。它还支持数据绑定、图形绘制、用户输入等多种功能，使得开发者能够创建功能丰富的客户端应用程序。此外，WinForm 应用程序可以轻松地访问本地硬件和文件系统，提供了与本地计算机紧密集成的能力。

WinForm 提供了各种控件，如文本框、按钮、复选框、下拉列表等，以及与这些控件相关的事件，如点击、输入、选择变更等。开发者可以通过编写事件处理函数来响应用户的操作，实现应用程序的交互逻辑。

### 3、开发流程

开发 WinForm 应用程序的基本流程包括：

1. **创建项目**: 在 Visual Studio 中创建一个新的 Windows 窗体应用程序项目。
2. **设计界面**: 使用 Visual Studio 的设计视图拖拽控件到窗体上，设置控件的属性和事件。
3. **编写代码**: 在 Form1.cs 文件中编写事件处理逻辑和应用程序的业务逻辑。
4. **运行和测试**: 运行应用程序，测试功能并调试代码。



总的来说，WinForm 是一个成熟且功能丰富的桌面应用程序开发框架，适合创建传统的 Windows 客户端应用程序。它的可视化设计能力和丰富的控件库使得开发过程更加便捷，而对本地资源的访问能力则确保了应用程序的强大功能。

### 4、应用场景

#### 4.1. 企业内部管理桌面系统（最常用场景）

适合工厂、制造业、公司内网客户端，不需要公网、只在局域网运行

- 工厂产线上位机软件（对接 PLC、视觉相机、传感器、扫码枪）半导体设备监控、3C 产线检测、流水线数据采集、设备参数调试工具
- 仓库管理系统 (WMS 桌面端)、车间 MES 客户端
- 内部 OA 桌面客户端、行政考勤、档案管理系统
- 质检系统：录入检测数据、导出 Excel、打印质检报表

> 特点：大量表单、表格、打印、串口 / 网口硬件通信，不需要炫酷界面，追求稳定、开发快。

#### 4.2. 设备调试工具 / 工控上位机（工业领域通用）

这也是很多自动化、视觉工程师在用 WinForm 的场景

- 视觉调试工具（搭配 VisionPro、Halcon、OpenCV）：图像展示、参数调节、相机触发、保存图片
- 硬件调试工具：串口、Modbus、TCP 客户端、PLC 调试助手、继电器控制器调试软件
- 仪器仪表上位机：示波器、温控设备、传感器数据实时展示、曲线绘图

> 优势：可以轻松调用 C# 底层通信库，控件稳定，老工控电脑（XP、Win7）完美兼容。

#### 4.3. 小型工具类软件、运维工具

运维人员、开发自用小工具

- 文件批量处理工具（批量重命名、格式转换、日志分析）
- 数据库桌面工具（简易数据查询、批量导入导出、数据修复）
- 日志查看器、端口监听工具、配置编辑器
- 桌面小工具：报表生成、Excel 批量处理

#### 4.4. 进销存、小型门店收银桌面软件

中小型商铺、个体户本地收银系统

- 本地单机版进销存、库存盘点、销售开单
- 收银前台（本地数据库 Sqlite/Access，断网也能使用）

> 注意：大型连锁收银现在更多 Web / 安卓端；单机本地版本依然大量使用 WinForm。

#### 4.5.教学实训软件

- C# 桌面程序教学案例、模拟实训系统
- 模拟仿真软件（模拟电梯、流水线、小车调度）

>  很多学校工控、计算机专业课程依然使用 WinForm 做实训项目。

#### 4.6. 传统政府 / 事业单位老旧桌面系统

大量存量历史系统：

 早年 .NET 时代开发的政务内网客户端、档案管理、国土测绘辅助软件。

> 现状：很多还在维护，需要程序员做迭代、Bug 修复、功能升级。

### 5、winform的优缺点

#### 5.1、适合选用 WinForm 的条件

1. 软件**只跑在 Windows 平台**，不需要跨平台（Mac/Linux）
2. 对内工具、工业软件、内网系统，不面向大众互联网用户
3. 开发周期短，界面不需要极致美观，优先保证稳定性
4. 需要对接硬件：串口、USB 设备、相机、PLC、扫码枪
5. 运行环境有老旧系统（Win7），WPF、MAUI 兼容性不如 WinForm
6. 大量表格（DataGridView）、打印、Office 交互（NPOI/EPPlus）

#### 5.2、不推荐使用 WinForm 的场景

1. 面向普通大众的互联网软件（大众更喜欢网页、App）
2. 需要跨平台（Windows+Mac+Linux）→ 优先 MAUI、WPF、Electron
3. 需要高度自定义炫酷 UI、动画、复杂可视化 → WPF / Avalonia
4. 移动端软件（手机平板）WinForm 完全不支持

#### 5.3、WinForm 竞品简单对比（讲课拓展素材）

1. **WPF**：自定义 UI 强大，底层 Direct 渲染；学习成本更高
2. **MAUI**：.NET 新一代跨平台框架，替代 WinForm/WPF 长期方案
3. **AvaloniaUI**：跨平台桌面 UI（Windows/Linux/Mac）
4. **Electron**：前端技术写桌面（VSCode、钉钉电脑版），占用内存高

## 二、WinForm 项目结构

### 1、创建项目

创建项目同样使用visual studio，项目模板选择windows窗体应用，老版本和新版本都可以，我们在这里以新版本为例：

![1785734413039](assets/1785734413039.png) 

![1787499127508](assets/1787499127508.png) 

![1785734554131](assets/1785734554131.png) 

一个典型的 WinForm 项目包含以下几个关键部分：

- **Form1.cs**: 窗体的事件逻辑源码，包含用户交互和应用程序逻辑。
- **Form1.Designer.cs**: 窗体的控件布局源码，由 Visual Studio 设计器自动生成，定义了窗体上的控件和布局。
- **Program.cs**: 应用程序的主入口点，负责启动初始窗口和运行应用程序。

![1785734653497](assets/1785734653497.png) 

### 2、控件

控件就像是构建界面的积木，它们帮助我们创建用户交互的界面元素，从而实现诸如输入数据、展示信息等基本功能。我们新创建的项目中，Form1是最大的控件，其中可以放其他控件。

在Winform中，常见的控件有：

- `Button` 控件用于触发事件，比如提交表单或执行命令。（按钮）
- `TextBox` 控件提供用户输入文本的区域。（输入框）
- `Label` 控件用来展示静态文本。（标签）

这些控件都可以通过拖拽放在界面中，点击顶部的【视图】选择下拉菜单中的工具箱，可以出现可拖拽操作的控件：

![1785734987039](assets/1785734987039.png) 

![1785735017136](assets/1785735017136.png) 

我们可以拖拽控件到设计界面：

![1785735162306](assets/1785735162306.png) 

控件的属性可以通过手动输入修改，鼠标右击控件，选择属性，可以打开属性列表：

![1785735252099](assets/1785735252099.png) 

![1785735389023](assets/1785735389023.png) 

这些控件也可以通过代码进行修改，甚至控件也可以通过代码创建操作。

### 3、代码阅读

入口文件代码：

```c#
internal static class Program
{
    
    // 开辟一个新线程，用于绘制程序UI
    [STAThread]
    static void Main()
    {
        // 应用配置初始化
        ApplicationConfiguration.Initialize();
        // 应用运行Form1实例化
        Application.Run(new Form1());
    }
}
```

Form1类：

```c#
// Form1是拆分类
public partial class Form1 : Form
{
    // 构造函数
    public Form1()
    {
        // 调用方法
        InitializeComponent();
    }
}
```

> `partial`（分部类型）作用：**把同一个类、结构体、接口拆分成多个代码文件，编译时合并成一个类型**。
>
> 编译器处理：多个 `partial class MyClass` → 最终生成**单个类**，不是继承、不是组合。

分部类Form1：

![1785735780485](assets/1785735780485.png) 

InitializeComponent方法：

```c#
private void InitializeComponent()
{
    // 实例化控件
    button1 = new Button();
    label1 = new Label();
    textBox1 = new TextBox();
    SuspendLayout();
    // 
    // button1控件的属性
    // 
    button1.BackColor = SystemColors.ActiveCaption; // 背景颜色
    button1.ForeColor = SystemColors.Highlight; // 文本颜色
    button1.Location = new Point(282, 108); // 左上角点位置
    button1.Name = "button1"; // 按钮名称
    button1.Size = new Size(75, 23); // 按钮大小
    button1.TabIndex = 0;
    button1.Text = "按钮"; // 文本内容
    button1.UseVisualStyleBackColor = false;
    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Location = new Point(192, 54);
    label1.Name = "label1";
    label1.Size = new Size(43, 17);
    label1.TabIndex = 1;
    label1.Text = "label1";
    // 
    // textBox1
    // 
    textBox1.Location = new Point(282, 48);
    textBox1.Name = "textBox1";
    textBox1.Size = new Size(173, 23);
    textBox1.TabIndex = 2;
    // 
    // Form1
    // 
    AutoScaleDimensions = new SizeF(7F, 17F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(800, 450);
    // 将3个控件添加窗体的控件集合中
    Controls.Add(textBox1);
    Controls.Add(label1);
    Controls.Add(button1);
    Name = "Form1";
    Text = "Form1";
    ResumeLayout(false);
    PerformLayout();
}

#endregion

private Button button1;
private Label label1;
private TextBox textBox1;
```

## 三、控件学习

### 1、Button

按钮。用于触发事件或执行特定操作的标准按钮。例如提交表单，点击后执行一段逻辑。

常用属性：

- `Text`: 按钮上显示的文本内容（如“确定”、“取消”）。
- `Name`: 在代码中引用该按钮的变量名（如 `button1`）。
- `ForeColor`: 按钮文本的字体颜色。
- `Location` / `Size`: 控件的位置和尺寸。
- `BackColor`：控件背景颜色
- `Font`：控件中的字体
- `TextAlign`：控件中文本对齐方式
- `visible`：显示隐藏控制

![1785837352561](assets/1785837352561.png) 

![1785837523599](assets/1785837523599.png) 

### 2、Label

标签。用于显示说明性文本，通常作为其他控件的标题或注释。

属性：

- `AutoSize`: 设置为 `true` 时，控件大小会根据文本内容自动调整。
- `borderStyle`: 设置边框样式（none 无边框 FixedSingle单边框，Fixed3D 边框立体效果）

### 3、TextBox

文本框。用于接收用户输入或显示单行/多行文本。

属性：

- `Text`: 获取或设置文本框中的内容。
- `Multiline`: 设置为 `true` 时，允许输入和显示多行文本。
- `ReadOnly`: 设置为 `true` 时，用户无法编辑内容，仅可查看。
- `PasswordChar`: 设置掩码字符（如 `*`），用于隐藏输入的密码等敏感信息。
- `PlaceholderText`： 输入框提示内容（有光标则隐藏）

![1785880567542](assets/1785880567542.png) 

![1785880650773](assets/1785880650773.png) 

![1785880796591](assets/1785880796591.png) 

### 4、CheckBox

复选框。允许用户在多个选项中进行多项选择。

属性：

- `Text`: 复选框旁边显示的说明文本。
- `Checked`: 获取或设置复选框是否被选中（`true` 或 `false`）。
- `ThreeState`: 设置为 `true` 时，复选框可以有三种状态（选中、半选中、不确定）。

![1785923266754](assets/1785923266754.png) 

![1785923366475](assets/1785923366475.png) 

### 5、RadioButton 

单选按钮。用于在一组互斥选项中进行单一选择。同一个容器下的单选按钮具有排他性，选中一个会自动取消其他选项的选中状态。

属性：

- `Text`: 单选按钮旁边显示的说明文本。
- `Checked`: 获取或设置单选按钮是否被选中。

![1785923506090](assets/1785923506090.png) 

### 6、ComboBox

下拉框。结合了文本框与下拉列表的复合控件。提供预设选项列表供用户选择，节省界面空间。

属性：

- `Items`: 下拉列表中包含的所有选项集合。
- `Text`: 可以设置默认显示的文本，或获取用户选择/输入的文本。
- `DropDownStyle`: 设置下拉框的样式，如是否允许用户编辑文本。
  - Simple：列表项窗口一直显示
  - DropDown：可以输入
  - DropDownList：不能输入

![1785923596227](assets/1785923596227.png) 

### 7、DateTimePicker 

日期时间选择器。专门用于选择和显示日期或时间的控件。提供一个日历界面，方便用户选择日期，无需手动输入。

属性：

- `Value`: 获取或设置当前选中的日期和时间。
- `Format`: 设置日期和时间的显示格式（如长日期、短时间等）。

![1785973735076](assets/1785973735076.png) 



### 8、LinkLabel 

超链接标签。外观类似超链接的标签控件。显示可点击的文本，通常用于打开网页或执行特定操作。

属性：

- `Text`: 显示的链接文本。
- `LinkColor`: 链接文本的颜色。
- `LinkVisited`: 设置链接是否显示为已访问过的颜色。

不直接设置链接，后续会通过事件设置链接。

![1785974062237](assets/1785974062237.png) 

### 9、ListBox 

列表框。用于显示一个项目列表，用户可以从中选择一个或多个项目。。

属性：

- `Items`: 列表框中包含的所有项目集合。
- `SelectionMode`: 设置列表框的选择模式（单选或多选）。
  - MultiSimple：鼠标点击切换选中状态；点一下选中，再点一下取消；不支持 Shift、Ctrl 快捷键
  - MultiExtended：支持鼠标拖拽、Ctrl 点选、Shift 区间选

![1785974506135](assets/1785974506135.png) 

### 10、RichTextBox 

富文本框。功能增强型文本控件，支持格式化文本及滚动浏览。相较于 `TextBox`，支持更复杂的文本排版（如不同字体、颜色）。

属性：

- `Text`: 获取或设置控件中的纯文本内容。
- `ReadOnly`: 设置为 `true` 时，用户无法编辑内容。

![1785974674316](assets/1785974674316.png) 

### 11、PictureBox 

图片框。专门用于加载和显示图像资源的容器。显示图片，支持多种图片格式。

属性：

- `Image`: 设置要显示的图像。
- `SizeMode`: 控制图片在控件内的显示方式（如拉伸、缩放、居中等）。
  - Normal：图片原始大小；控件不够大就裁剪，控件大图片不动，左上角对齐
  - StretchImage：图片拉伸变形填满整个控件，会改变图片宽高比
  - AutoSize：控件自动跟着图片大小改变，控件适应图片
  - CenterImage：图片保持原始大小，在 PictureBox 内部居中显示；图片大就四周裁剪
  - Zoom：图片按比例缩放，不变形，完整放进控件内部

![1785974949980](assets/1785974949980.png) 

## 四、容器和控件

### 1、概念

winform界面由都是由控件组件的。但有些控件需要进行分组管理，才好操作，例如单选框，如果一个界面中需要多组单选框，我们都放在Form这个窗体（控件）中，就会让所有单选按钮都互斥，无法实现分组的效果。

例：

![](assets/单选按钮互斥.gif) 

为了能实现分组，winform将控件分为两类，一类是普通控件，也就是我们上面学习的，另一类是容器控件，就像Form控件，可以在里面装普通控件，达到分组管理的目的。也就是说winform界面是由控件之间互相嵌套形成的。Form属于根容器，里面可以放在普通控件，也可以放其他容器。容器也是可以嵌套容器的。



容器控件又分为两种，一种是能控制子控件布局的容器，另一种是不能控制子控件布局的。

能控制子控件布局的容器，我们又称为布局容器。不能控制子控件布局的容器，我们叫做简单容器。

### 2、简单容器

简单容器只提供存放区域，不自动布局，所以不会控制子控件的布局方式，子空间的布局方式由子空间自己的属性操作，例如：`Location`、`Size`、`Location`、`Anchor`、`Dock`等，子控件设置后，就生效，不会被父容器的布局方式所忽略。

#### 2.1、Form

窗体根容器：

- `Text`：窗体标题
- `MaximizeBox `：是否显示最大化按钮
- `MinimizeBox`：是否显示最小化按钮
- `StartPosition `：启动后窗体显示的位置
  - Manual：窗体的位置由 `Location` 属性决定；如果不设置 Location，默认出现在屏幕左上角 (0,0)。
  - CenterScreen：屏幕中央。
  - WindowsDefaultLocation：系统决定窗体初始位置，大小由 Size 决定；一般出现在屏幕左上角区域，由 Windows 窗口管理器分配。
  - WindowsDefaultBounds：Windows 默认边界。系统不仅决定位置，连窗体的 Size 大小也由系统决定，代码设置的 Size 会被忽略。
  - CenterParent父窗体中央。窗体出现在它父窗体的中间。多用于子弹窗、对话框；如果是主窗体（没有父窗体），效果相当于 `CenterScreen`）

#### 2.2、Panel

面板容器控件。最基础的容器，默认无边框、无标题。它本身不包含自动排列逻辑，但支持所有手动和自动布局属性（`Dock`, `Anchor`, `AutoSize`）。通常用于分组，让内部的子控件跟外部不产生自动的关联。

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
  -  Bottom,Right：窗口拉大，控件始终待在右下角，适合【确定 / 取消】按钮。

- `AutoSize`：自动大小。控件根据自己内容，自动调整自身的大小，把内容刚好包住。

注意：Anchor 不能和 Dock 同时生效：只要设置 Dock，Anchor 会被忽略。**Dock 优先级高于 Anchor**。如果只写 `Anchor = Bottom`，没有写 Top，控件会垂直移动，而不是拉伸。

#### 2.3、GroupBox

分组框容器控件。功能与 `Panel` 类似，但自带边框和标题（`Text` 属性）。主要用于在视觉上对功能模块进行分组，增强界面的层次感。没有滚动条。

#### 2.4、TabControl

选项卡容器。可以在同一个位置出现多个容器，点击标题可以切换容器展示。

属性：

- `TabPages`：集合，可以添加删除选项卡。
- `Multiline`：`true`：标签文字多行显示。标签很多的时候，标签会折成多行；false 只能单行，出现滚动小箭头。
- `Alignment`：标签摆放位置：Top 顶部 (默认)、Bottom 底部、Left 左侧、Right 右侧。标签可以放到上下左右四边。
- `ShowToolTips`：是否显示 TabPage 的 ToolTip 提示。

### 3、布局容器

布局容器的内部子控件尽量不要手动设置 Location，会失效，由容器规则控制。

#### 3.1、FlowLayoutPanel

流式布局面板。内部控件像水流一样，按照指定的方向（水平或垂直）自动排列。当一行/一列的空间不够时，会自动换行/换列。

属性：

- `FlowDirection`（流向）
- `WrapContents`（是否允许换行）。
- `Padding`：容器内部边距，所有控件距离容器四边留出空隙。

FlowLayoutPanel 内部的子控件，Anchor 会失效。Flow 布局会接管子控件位置，子控件的 Anchor 不起作用。Dock 对子控件同样无效。

#### 3.2、TableLayoutPanel

表格布局面板。以行和列组成的网格形式排列控件，支持单元格合并（`ColumnSpan`, `RowSpan`）。

属性：

- `RowStyles` 和 `ColumnStyles`（可设置绝对像素值、百分比或自适应大小）。

- 若要合并单元格，需要给子控件设置合并，设置Dock才能看到效果。

#### 3.3、SplitContainer

分割面板。自带一个可拖动的分割条，将容器分为两个独立的面板（`Panel1` 和 `Panel2`）。

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

