---
typora-copy-images-to: assets
---

# day04

## 一、上节回顾

### 事件参数对象

> 事件触发时候,给事件处理函数传递个第二个参数, 其中包含了所有的本次事件信息

#### 鼠标事件参数对象

- 相对父容器 X 轴坐标 `e.X`
- 相对父容器 Y 轴坐标 `e.Y`
- `e.Location`  ==> `new Point()`
- `e.Button` 按键信息 
- `e.Clicks` 点击次数  1,2
- `e.Delta` 滚轮的距离
  - `MouseWheel`  鼠标滚轮事件

#### 键盘事件参数对象

- `KeyEventArgs`
  - `e.KeyCode`  按键内容 得到一个枚举值  `Keys`
  - `e.Control`  是否按下ctrl
  - `e.Shift`
  - `e.Alt`
  - `e.Handled`  抑制输入  
- `KeyPressEventArgs`
  - `e.KeyChar`  返回键入的字符  得到一个字符

##### 控件.Focus()

- 给控件获取焦点(光标)

#### 字体

- `new Font(字体, 字号大小9F, 字体样式(下划线,倾斜,加粗..)FontStyle.Underline, 字号单位GraphicsUnit.Point,字体编码134);`

#### 杂项

- `控件.Visible = false;`  控制控件的可见性
- 在实际开发中, 尽量不要在代码中去修改 控件的边框样式, 应为会自动的销毁窗体控件 重新布局, 需要消耗内存
- `下拉框.DroppedDown = true/false`  控制下拉框展开收起
- `窗体实例.Close()`  关闭窗体

```C#
控件.Click += 处理函数

处理函数(object sender,EventArgs e){
	//注意在具体的事件处理函数中,我们需要使用sender(事件源)的时候 需要将其转为目标类型
	// 使用事件参数对象的时候也是一样: 比如此时需要使用的是 鼠标事件参数对象则需要将e类型转换
	MouseEventArgs ev = (e as MouseEventArgs); // as 转换失败则 结果为null
    if(ev != null){
    
    
    }

}


```



## 二、事件

### 键盘控制方向移动

将窗体的FormBorderStyle设置为none，将顶部的标题栏删掉，否则会影响距离计算。

```C#

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

### 统计按键按下时长

```C#
 private int speed = 15;

 // 按键按下的开始时间
 private DateTime StartTime { get; set; }

 // 键盘按下事件 键盘一直按下会一直执行
 // 使用开关控制目标代码执行
 // 判断开关是开 则执行目标代码
 //      第一次触发按下事件 则将 开关关闭
 //      那么后续长按触发的事件 开关都是关闭的则不会执行目标代码
 // 只有当按键松开的时候 则开关打开

 // 定义一个开关属性,
 private bool flag = true;
 private void LunBoTu_KeyUp(object sender, KeyEventArgs e)
 {
     // 打开开关
     flag = true;

     // 在键盘松开事件中 获取 结束时间 
     DateTime EndTime = DateTime.Now;
     // 并计算时差 展示在label中
     TimeSpan diff =  EndTime - StartTime;
     // 转ms
     labelTime.Text = diff.TotalMilliseconds.ToString();
     label2.Text = n.ToString();
 }

 private int n = 0;
 private void Move_KeyDown(object sender, KeyEventArgs e)
 {
     if (flag)  // 开关打开才执行
     {
         n++;
         // 按键按下时间功能
         StartTime = DateTime.Now;
         // 关闭开关
         flag = false;
     }
     


     // 按键控制移动
     Point bl = box.Location;
     // 获取窗体的尺寸
     int formWidth = this.Width;
     int formHeight = this.Height;
     // 获取 移动控件的尺寸
     int boxWidth = box.Width;
     int boxHeight = box.Height;
     // 计算最大运动距离
     int xMax = formWidth - boxWidth;
     int yMax = formHeight - boxHeight;


     switch (e.KeyCode)
     {
         case Keys.W:
             bl.Y -= speed;
             if (bl.Y <= 0) bl.Y = 0;
             break;
         case Keys.S:
             bl.Y += speed;
             if (bl.Y >= yMax) bl.Y = yMax;
             break;
         case Keys.A:
             bl.X -= speed;
             if (bl.X <= 0) bl.X = 0;
             break;
         case Keys.D:
             bl.X += speed;
             if (bl.X >= xMax) bl.X = xMax;
             break;
         default:
             break;
     }
     box.Location = bl;


     // 判断键盘按下的是否是ESC 是就退出窗体
     if (e.KeyCode == Keys.Escape) this.Close();
 }

 public LunBoTu()
 {
     InitializeComponent();
     // 键盘控制方向移动
     this.KeyDown += Move_KeyDown;

     // 按键按下时间功能
     // 键盘松开事件
     this.KeyUp += LunBoTu_KeyUp;
 }
```



### 限制删除

```c#
public XianZhiShanChu()
{
    this.InitializeComponent();
    // 给输入框绑定事件
    textBox1.KeyPress += textBox1_KeyPress;
   
}
private void textBox1_KeyPress(object sender, EventArgs e)
{
    // 输入的内容如果不是删除键就正常输入，如果是删除键就取消这次输入操作
    // 事件参数对象类型转换成具体的KeyPress用的类型
    KeyPressEventArgs ev = (KeyPressEventArgs)e;
    // 获取输入的是哪个键
    char letter = ev.KeyChar;
    // 判断
    //if (letter == (char)8) // char除了可以代表单个字符的字符串，也可以代表键盘码的字符
    //if (letter == (char)52)
    if (letter == '4')
    {
        // 取消这次操作
        ev.Handled = true;
    }
}
```

### 放大控件

```c#
public FangDaPB()
{
    InitializeComponent();
    pictureBox1.MouseEnter += pictureBox1_MouseEnter;
}
private void pictureBox1_MouseEnter(object sender, EventArgs e)
{
    // 移入了：放大pictureBox1 ==> 调整控件大小 ==> Width/Height
    PictureBox pb = (PictureBox)sender;
    // 设置宽度和高度
    pb.Width += 300;
    pb.Height += 200;
}

private void pictureBox1_MouseLeave(object sender, EventArgs e)
{
    pictureBox1.Width -= 300;
    pictureBox1.Height -= 200;
}
```

### 鼠标移入出现提示

```c#
private Label lb;
private int num = 0;
private bool tiaojian = true;
private void button1_MouseEnter(object sender, EventArgs e)
{
    // 需要出现一个提示词
    lb = new Label();
    lb.Name = "lb";
    lb.Text = "阿斯克码表";
    lb.Location = new Point(button1.Left, button1.Top + button1.Height);
    // 获取时间
    DateTime startTime = DateTime.Now;
    while(tiaojian)
    {
        //num++;
        //label1.Text = num.ToString();
        // 移入2秒后 才展示提示词
        DateTime endTime = DateTime.Now;
        if ((endTime - startTime).TotalSeconds >= 2)
        {
            this.Controls.Add(lb);
            tiaojian = false;
            break;
        }
    }
}

private void button1_MouseLeave(object sender, EventArgs e)
{
    // 隐藏/删除提示词 
    this.Controls.Remove(lb);
    tiaojian = true;
}
```

### 限制最大输入长度

```c#
private int maxlength = 10;
private void textBox1_TextChanged(object sender, EventArgs e)
{
    //EventArgs as Args
    // 只要输入了内容，或删除一个字符都会执行
    if (textBox1.Text.Length > maxlength) {
        // 阻止输入
        label1.Visible = true;
        // 截取Text内容
        string str = textBox1.Text.Substring(0, 10);
        textBox1.Text = str;
        // 设置光标位置
        textBox1.SelectionStart = maxlength;
    }else{
        label1.Visible = false;
    }
}
```

![](assets/限制最大输入长度.gif)

### 列表框数据过滤

```c#
private List<string> CobItems = new List<string>
{
    "11112222333","22222","1111144444","222222444","22222","11111444","444444","444444","333333"
};
public GuoLvLieBiao()
{
    InitializeComponent();
    // 清空items
    listBox1.Items.Clear();
    // 给列表框设置Items列表项
    listBox1.Items.AddRange(CobItems.ToArray());
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
    // 获取到当前输入进去的内容
    string keywords = textBox1.Text;
    // 通过keywords关键字从list中筛选出所有带关键字的
    List<string> result = CobItems.FindAll(item => item.Contains(keywords));
    // 清空items
    listBox1.Items.Clear();
    // 给列表框设置Items列表项
    listBox1.Items.AddRange(result.ToArray());

}
```

![](assets/列表框筛选.gif) 

### 获取到列表框选中项

```c#
public GuoLvXiaLaK()
{
    InitializeComponent();
    // 清空items
    listBox1.Items.Clear();
    // 给列表框设置Items列表项
    listBox1.Items.AddRange(CobItems.ToArray());
    // 给列表框添加选中项改变的事件
    listBox1.SelectedIndexChanged += change;
}
private void change(object sender, EventArgs e)
{
    // 将选中项的文本获取到
    string str = listBox1.SelectedItem.ToString();
    // 放在label2里面
    label2.Text = str;
}
```

![1786518742691](assets/1786518742691.png) 

### 密码强度检测

```c#
private void textBox1_TextChanged(object sender, EventArgs e)
{
    // 获取到文本框的内容
    string str = textBox1.Text;
    // 定义数字
    int num = 0;
    if (Regex.IsMatch(str, @"\d"))
    {
        num++;
    } 
    if (Regex.IsMatch(str, @"[A-Z]"))
    {
        num++;
    } 
    if (Regex.IsMatch(str, @"[a-z]"))
    {
        num++;
    }
    // 定义要在label中展示的结果字符串
    string result = "";
    Color resultColor = Color.Black;
    switch(num)
    {
        case 1:
            result += "弱";
            resultColor = Color.Red;
            break;
        case 2:
            result += "中";
            resultColor = Color.Yellow;
            break;
        case 3:
            result += "强";
            resultColor = Color.LightGreen;
            break;
    }
    label1.Text = result;
    label1.ForeColor = resultColor;
    //label1.Visible = true;
}
```

![](assets/密码强度检测.gif) 

### 输入数字自动千分位分割

```c#
private void textBox1_TextChanged(object sender, EventArgs e)
{
    // 获取到输入的内容
    string text = textBox1.Text;
    // 去除所有逗号
    text = Regex.Replace(text, @",", "");
    // 转整型
    int num = int.Parse(text);
    // 千分位分割 格式化转换
    string result = num.ToString("#,#");
    // 将结果放入输入框
    textBox1.Text = result;
    // 处理光标位置
    textBox1.SelectionStart = result.Length;
}
```

![](assets/输入千分位分割.gif) 

### 输入自动转大小写

```c#
private void textBox2_TextChanged(object sender, EventArgs e)
{
    // 获取输入内容
    string text = textBox2.Text;
    // 转大写
    text = text.ToUpper();
    // 放入文本框
    textBox2.Text = text;
    // 处理光标
    textBox2.SelectionStart = text.Length;
}
```

### 总价的实时计算

实时计算：单价 × 数量自动算出金额

```c#
// 为了让单价和数量有对应关系，创建数据
private List<Dictionary<string, Control>> list = new List<Dictionary<string, Control>>() { };

public JiSuanZongJia()
{
    InitializeComponent();
    // 将控件之间的关系用数据存起来
    list.Add(new Dictionary<string, Control>()
    {
        ["label"] = label8,
        ["number"] = textBox1
    });
    list.Add(new Dictionary<string, Control>()
    {
        ["label"] = label9,
        ["number"] = textBox2
    });

    // 给两个输入框绑定内容改变事件
    textBox1.TextChanged += change;
    textBox2.TextChanged += change;
}
private void change(object sender, EventArgs e)
{
    // 定义存储总价的变量
    int total = 0;
    foreach (Dictionary<string, Control> item in list)
    {
        total += int.Parse(item["label"].Text) * int.Parse(item["number"].Text);
    }
    label2.Text = total.ToString();
}
```

![](assets/输入数量自动计算总价.gif) 



### 作业

![](assets/计算作业.gif)





### 二级联动

```c#
private List<Dictionary<string, dynamic>> data { get; set; }
public LianDong()
{
    InitializeComponent();
    // 初始化数据
    data = new List<Dictionary<string, dynamic>>()
    {
        new Dictionary<string, dynamic>()
        {
            ["id"] = 1,
            ["name"] = "广东省",
            ["parent_id"] = 0
        },
        new Dictionary<string, dynamic>()
        {
            ["id"] = 2,
            ["name"] = "深圳市",
            ["parent_id"] = 1
        },
        new Dictionary<string, dynamic>()
        {
            ["id"] = 3,
            ["name"] = "广州市",
            ["parent_id"] = 1
        },
        new Dictionary<string, dynamic>()
        {
            ["id"] = 4,
            ["name"] = "广西省",
            ["parent_id"] = 0
        },
        new Dictionary<string, dynamic>()
        {
            ["id"] = 5,
            ["name"] = "桂林市",
            ["parent_id"] = 4
        },
        new Dictionary<string, dynamic>()
        {
            ["id"] = 6,
            ["name"] = "柳州市",
            ["parent_id"] = 4
        }
    };
    // 筛选所有省
    List<Dictionary<string, dynamic>> province = data.FindAll(item => item["parent_id"] == 0); 
    var arr = province.Select(item => item["name"]);
    comboBox1.Items.Clear();
    comboBox1.Items.AddRange(arr.ToArray());
    // 给下拉框选项改变的事件
    comboBox1.SelectedIndexChanged += change;
}
private void change(object a, EventArgs b)
{
    // 找到当前选中项的内容
    string text = comboBox1.SelectedItem.ToString();
    // 从data中获取到这个省份名称对应的id
    Dictionary<string, dynamic> dic = data.Find(item => item["name"] == text);
    // 根据省份id 筛选出所有对应的市数据
    List<Dictionary<string, dynamic>> city = data.FindAll(item => item["parent_id"] == dic["id"]);
    var arr = city.Select(item => item["name"]);
    comboBox2.Items.Clear();
    comboBox2.Items.AddRange(arr.ToArray());
    comboBox2.Text = "请选择市";
}
```

![](assets/二级联动.gif)



### 多控件用同一个函数处理事件

```c#
private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
{
    ComboBox cbo = sender as ComboBox;
    if(cbo == null || cbo.SelectedIndex == -1) return;

    if(cbo.Name == "cboSort")
    {
        MessageBox.Show("排序条件改变");
    }
    else if(cbo.Name == "cboFilter")
    {
        MessageBox.Show("过滤条件改变");
    }
}
```



### 下拉框换皮肤

```c#
private void cboTheme_SelectedIndexChanged(object sender, EventArgs e)
{
    string theme = cboTheme.SelectedItem.ToString();
    switch (theme)
    {
        case "默认":
            this.BackColor = SystemColors.Control;
            break;
        case "深色":
            this.BackColor = Color.DarkGray;
            break;
        case "淡蓝":
            this.BackColor = Color.LightBlue;
            break;
    }
}
```

### 全选反选

### 拖拽

坐标转换：

```c#
// 将鼠标在控件上的坐标换算成鼠标在屏幕上的坐标
控件.PointToScreen(e.Location)
// 从原坐标上偏移
Point坐标.Offset(+1, -1)
// 将Point坐标换算成某个父容器内部的坐标
父容器.PointToClient(Point坐标);
```

## 三、窗体操作

### 1、新建窗体

一个项目可以有很多界面，这时候就需要我们手动创建其他窗体了。

在项目文件夹上右击，选择【添加】==>【窗体】

![1786268316238](D:/%E8%A7%86%E8%A7%8902/00%E6%9D%82%E9%A1%B9/%E6%96%B0%E5%BB%BA%E6%96%87%E4%BB%B6%E5%A4%B9/00%E8%B5%84%E6%96%99/02day/assets/1786268316238.png) 

输入窗体名称：

![1786268382957](D:/%E8%A7%86%E8%A7%8902/00%E6%9D%82%E9%A1%B9/%E6%96%B0%E5%BB%BA%E6%96%87%E4%BB%B6%E5%A4%B9/00%E8%B5%84%E6%96%99/02day/assets/1786268382957.png) 

然后就看到新建的窗体了：

![1786268406333](D:/%E8%A7%86%E8%A7%8902/00%E6%9D%82%E9%A1%B9/%E6%96%B0%E5%BB%BA%E6%96%87%E4%BB%B6%E5%A4%B9/00%E8%B5%84%E6%96%99/02day/assets/1786268406333.png) 

### 2、窗体方法

窗体有几个常用方法，可以用于让窗体隐藏显示，实现跳转逻辑：

```c#
窗体.Show(); // 窗体显示
窗体.Hide(); // 窗体隐藏
窗体.Close(); // 窗体关闭
Application.Exit(); // 退出整个应用程序 
```

### 3、窗体事件

| 事件          | 触发时机                     | 场景                                   |
| ------------- | ---------------------------- | -------------------------------------- |
| `Load`        | 窗体第一次加载显示前执行     | 初始化数据、给控件赋值，**只执行一次** |
| `Shown`       | 窗体已经显示出来之后         | 窗体完全渲染完成后执行                 |
| `FormClosing` | 窗体正在关闭（可以取消关闭） | 关闭前弹窗确认是否退出                 |
| `FormClosed`  | 窗体已经关闭完成             | 释放资源、打开其他窗体                 |
| `Resize`      | 窗体大小改变                 | 窗口缩放，适配控件布局                 |

