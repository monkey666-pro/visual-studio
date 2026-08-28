---
typora-copy-images-to: assets
---

# day03

## 一、上节回顾

### 容器

> 容器都可以承载控件,简单容器和布局容器

##### 简单容器

- Form 窗体容器 根容器
- Panel 简单面板容器
- GroupBox 分组容器
- TabControl 选项卡容器

##### 布局容器

- 流式布局容器  FlowLayoutPanel
- 表格布局容器  TabLayoutPanel
- 分隔容器   SplitContainer

### Controls

> 所有容器控件都有的属性
>
> 容器.Controls  可以对子控件的操作
>
> 容器.Controls  也表示子控件的集合

- Add/AddRange/Rmove/RemoveAt/Clear/Indexof/Contains/GetChildIndex/SetChildIndex/Count ...
- 控件.Parent

### 事件

> 事件源   事件类型   事件处理程序

`事件源.事件类型 += 事件处理程序`

> 一个事件类型 可以绑定多个事件处理程序
>
> 解除事件处理程序绑定:  事件源.事件类型 -= 事件处理程序

#### 事件类型

- 鼠标类
  - 左键单击
  - 按键按下
  - 按键松开
  - 鼠标移入
  - 鼠标移出
  - 鼠标移动
- 键盘类
  - 按键按下
  - 按键松开
  - 按键键入
- 光标类
  - 获取焦点 GetFocus
  - 失去焦点 Leave
  - Validating   失去焦点的校验
  - validated    
  - LostFocus 真正失去焦点

- 输入类
  - 内容改变 
- 列表类
  - 选中项改变

## 二、事件

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

| 属性       | 说明                         |
| ---------- | ---------------------------- |
| `e.Cancel` | bool，`true`阻止焦点离开控件 |

### 5、案例

#### 轮播图（Click）

![](assets/轮播图.gif) 

#### 模拟链接（移入移出）

```c#
private void lab2_MouseEnter(object sender,EventArgs e)
{
    // 高亮 下划线
    lab2.ForeColor = Color.Purple;
    // 字体  大小 样式  单位
    lab2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point);

}
private void lab2_MouseLeave(object sender, EventArgs e)
{
    // 高亮 默认
    lab2.ForeColor = Color.Blue;
    lab2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
}

```

![](assets/模拟链接.gif) 

#### 光标位置的实时显示（移动）

代码：

![1786417422896](assets/1786417422896.png) 

效果：

![](assets/实时显示光标位置.gif) 



#### 输入框数据校验（焦点）

```c#
 public CursorLocation()
 {
     InitializeComponent();
 
     // 给输入框绑定 失去焦点 触发
     textBox1.Leave += TextBox1_Leave;
     // 给输入框绑定 获取焦点 触发
     textBox1.GotFocus += TextBox1_GotFocus;
 }
private void TextBox1_GotFocus(object sender, EventArgs e)
{
    // 将两个lab 隐藏
    labT.Visible = false;
    labF.Visible = false;
}

private void TextBox1_Leave(object sender, EventArgs e)
{
    // 获取输入框的内容
    string content = (sender as TextBox).Text;
    // 根据正则校验 内容是否符合要求  @"^1[1-9]\d{9}$"
    if (Regex.IsMatch(content, @"^1[1-9]\d{9}$"))
    {
        // 通过labT 展示
        labT.Visible = true;
    }
    else
    {
        // 如果不通过则 labF 展示
        labF.Visible = true;
    }

}
```

![](assets/数据校验.gif) 

#### 获取焦点后高亮

```c#
public FocusWork()
{
    InitializeComponent();
    InitFocusHieghtLigth(); // 获取焦点后高亮
}
public void InitFocusHieghtLigth()
{
    // 给 按钮 添加 获取焦点和失去焦点 事件
    button1.GotFocus += Button1_GotFocus;
    button1.Leave += Button1_Leave;

    textBox1.GotFocus += TextBox1_GotFocus;
    textBox1.Leave += TextBox1_Leave;

}

private void TextBox1_Leave(object sender, EventArgs e)
{
    (sender as TextBox).BackColor = Color.White;
    (sender as TextBox).ForeColor = Color.Black;
    (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;
}

private void TextBox1_GotFocus(object sender, EventArgs e)
{
    (sender as TextBox).BackColor = Color.Orange;
    (sender as TextBox).ForeColor = Color.Blue;
    (sender as TextBox).BorderStyle = BorderStyle.Fixed3D;
}

private void Button1_Leave(object sender, EventArgs e)
{
    // 高亮
    (sender as Button).BackColor = Color.White;
    (sender as Button).ForeColor = Color.Black;

}

private void Button1_GotFocus(object sender, EventArgs e)
{
    // 高亮
    (sender as Button).BackColor = Color.Orange;
    (sender as Button).ForeColor = Color.Blue;

}
```

![](assets/获取焦点后高亮.gif) 

#### 下拉框获取焦点展开

```c#
public FocusWork()
{
    InitializeComponent();   
    InitFocusOpen(); // 下拉框获取焦点展开
}
public void InitFocusOpen()
{
    // 给下拉框 获取焦点 和失去焦点事件
    comboBox1.GotFocus += ComboBox1_GotFocus;
    comboBox1.Leave += ComboBox1_Leave;
}

private void ComboBox1_Leave(object sender, EventArgs e)
{
    (sender as ComboBox).DroppedDown = false;
}

private void ComboBox1_GotFocus(object sender, EventArgs e)
{
    // 下拉框.DroppedDown  设置 下拉框是否展开 
    (sender as ComboBox).DroppedDown = true;

}
```

![](assets/下拉框自动展开.gif) 

#### 焦点拦截

强制让输入框不能为空，如果为空，一直无法失去焦点。

```c#
public FocusNoGo()
{
    InitializeComponent();
    InitFocusNoGo();
}

private void InitFocusNoGo()
{
    // 绑定事件
    tb1.Leave += Tb1_Leave; // 光标离开事件
    tb1.TextChanged += tb1_TextChanged;
   
}

private void tb1_TextChanged(object sender, EventArgs e)
{
    // 获取输入框的内容
    TextBox tb = (sender as TextBox);
    string conent = tb.Text;
    if (!string.IsNullOrEmpty(conent)) label1.Visible = false;
}


private void Tb1_Leave(object sender, EventArgs e)
{
    // 获取输入框的内容
    TextBox tb = (sender as TextBox);
    string conent = tb.Text;
    // 判断内容是否为空
    if (string.IsNullOrEmpty(conent))
    {
        tb.Focus();  //输入控件.Foucs()     作用: 让输入控件获取光标
        label1.Visible = true;
    }
    
}
```

![](assets/焦点拦截.gif) 

#### 回车键提交表单

KeyDown：任意键按下都会执行，不松开，一直执行

KeyPress：只要有输入内容就会执行，看起来很想KeyDown

KeyUp：按下键盘后，抬起，执行一次

```c#
public KeyTest()
{
    InitializeComponent();
    InitEnter(); // 回车键(提示)提交表单
}
public void InitEnter()
{
    // 给输入框 绑定  键盘松开  
    textBox1.KeyUp += TextBox1_KeyUp;

}

private void TextBox1_KeyUp(object sender, KeyEventArgs e)
{
    // 判断 keyCode 是否是 回车按键
    if (e.KeyCode == Keys.Enter)
    {
        MessageBox.Show("模拟提交");
    }
}
```

![](assets/回车键提交.gif) 

#### ESC退出窗体

> 窗体实例.close()    可以实现窗体关闭

```c#
public KeyTest()
{
    InitializeComponent();
    InitEsc();// ESC退出窗体 
}
public void InitEsc()
{
  
    // 给 窗体 绑定 按键按下
    this.KeyDown += KeyTest_KeyDown;

}

private void KeyTest_KeyDown(object sender, KeyEventArgs e)
{
    // e.KeyCode 是否是 Escape
    if (e.KeyCode == Keys.Escape) {
        this.Close(); // 关闭窗体
    }
    
}
```

#### 组合键保存、复制

> 常见的组合键: ctrl+s / ctrl+c /ctrl+v .....

```c#
public KeyTest2()
{
    InitializeComponent();
    InitCtrl(); // 组合键保存、复制
}
public void InitCtrl()
{
    // 给输入框绑定 键盘按下事件
    textBox1.KeyDown += TextBox1_KeyDown;
}

private void TextBox1_KeyDown(object sender, KeyEventArgs e)
{
    // 判断按键  e.Control 及 按键是否是C 
    if(e.Control && e.KeyCode == Keys.C)
    {
        MessageBox.Show("你要复制了吗?");
    }

    if (e.Control && e.KeyCode == Keys.S)
    {
        MessageBox.Show("你要保存了吗?");
    }
}
```

#### 限制文本框只能输入数字

```c#
public KeyTest2()
{
    InitializeComponent();   
    InitNum(); // 限制文本框只能输入数字
}
public void InitNum()
{
    // 字符之间可以直接比较大小  字符之间的比较是 编码的 比较
    // --字符先转为编码值(int)然后比较大小----
    //MessageBox.Show(('1' > '0').ToString());
    //MessageBox.Show(('a' > '0').ToString());

    // 给输入框绑定 键盘按下事件
    textBox2.KeyPress += TextBox2_KeyPress;
}

private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
{
    //e.Handled = true; // 拦截输入

    // e.KeyChr 获取按下的字符

    // 判断按下的字符是否是数字
    if (e.KeyChar < '0' || e.KeyChar > '9')
    {
        //输入的不是数字,则拦截输入
        e.Handled = true;
    }
}
```

![](assets/数字输入限制.gif) 

#### 键盘控制方向移动

将窗体的FormBorderStyle设置为none，将顶部的标题栏删掉，否则会影响距离计算。

```c#

private int speed = 5;
public Move()
{


    InitializeComponent();
    // 键盘控制方向移动
    this.KeyDown += Move_KeyDown;
    // 获取控件的尺寸
    //MessageBox.Show(box.Width.ToString());
    //MessageBox.Show(this.Height.ToString());
}

private void Move_KeyDown(object sender, KeyEventArgs e)
{
    Point bl = box.Location;

    switch (e.KeyCode)
    {
        case Keys.W:
            bl.Y -= speed;
            break;
        case Keys.S:
            bl.Y += speed;
            break;
        case Keys.A:
            bl.X -= speed;
            break;
        case Keys.D:
            bl.X += speed;
            break;
        default:
            break;
    }
    box.Location = bl;
}
```

![](assets/键盘控制移动方向.gif) 

#### 统计按键按下时长

```c#

```



