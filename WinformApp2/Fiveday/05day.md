---
typora-copy-images-to: assets
---

# day05

## 一、上节回顾

##### 操作控件尺寸

- 获取: `控件.Width/Height`
- 设置: `控件.Width/Height`  赋值

##### 获取位置信息

- 坐标信息的 类型 `Point`

- 控件坐标信息: `控件.Location` 获取到的是相对于父容器
  - `控件.Location.X`  == `控件.Left`控件相对于父容器左边的距离
  - `控件.Location.Y`  == `控件.Top`控件相对于父容器顶部的距离

- 获取鼠标坐标信息: 必须要在鼠标事件处理程序中通过事件参数对象才能获取 `e.Location`
  - `e.Location.X` `e.X`/ `e.Location.Y` / `e.Y`

##### 开关思想

> 一般通过定义一个变量/属性 存储开关状态
>
> 开关状态在 频繁操作的程序中(比如: 键盘按下事件处理函数) 改为关闭(这个程序中执行的关键步骤[获取初次按下的时间])而程序中需要开关开的时候才执行关键步骤
>
> 在处理完目标操作后(按键松开获取到结束事件后) 才将开关打开

##### 输入框光标处理

- 获取光标位置: `控件.SelectionStart`
- 获取光标位置: `控件.SelectionStart = 数字`

##### 列表框(ListBox)选项操作

- 获取所有子选项: `控件.Items`
- 添加子选项: `控件.Items.Add(字符串)`
- 批量添加子选项: `控件.Items.AddRange(数组)`
- 删除子选项: `控件.Items.Remove(子选项)`
- 清空: `控件.Clear()`
- 下拉列表框(ComboBox)的选项操作也是一样的
  - `控件.Items`
  - `Addm/AddRange/Clear`





## 二、事件

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

![](D:/%E8%A7%86%E8%A7%8902/02-WinForm%E9%98%B6%E6%AE%B5/04day/01-%E8%AF%BE%E4%BB%B6/04day/assets/%E4%BA%8C%E7%BA%A7%E8%81%94%E5%8A%A8.gif)



### 多控件用同一个函数处理事件

```C#
public Form2()
{
    InitializeComponent();

    // 初始数据
    PriceCb.Items.AddRange(["升序", "降序"]);
    TimeCb.Items.AddRange(["升序", "降序"]);

    // 绑定事件
    PriceCb.SelectedIndexChanged += Change;
    TimeCb.SelectedIndexChanged += Change;

}
private void Change(object sender, EventArgs e)
{
    ComboBox cb = (sender as ComboBox);
    // 判断是哪个下拉框
    if (cb.Name == "PriceCb")
    {
        // 模拟排序
        if(cb.SelectedItem.ToString() == "升序")
        {
            MessageBox.Show("按照价格升序排序");
        }
        else
        {
            MessageBox.Show("按照价格降序排序");
        }
    }
    else
    {
        if (cb.SelectedItem.ToString() == "升序")
        {
            MessageBox.Show("按照上架时间升序排序");
        }
        else
        {
            MessageBox.Show("按照上架时间降序排序");
        }
    }
    
}
```



![](./assets/多控件用同一个函数处理事件.gif)

### 下拉框换皮肤

```C#
public class BcColor
{
    public string Name;
    public Color _Color;
    public BcColor(string Name, Color _Color) {
        this.Name = Name;
        this._Color = _Color;
    }
}

public partial class Form3 : Form
{
    private List<BcColor> ColorList= new ();
    public Form3()
    {
        InitializeComponent();
        // 初始化数据
        ColorList.AddRange([
            new BcColor("红色",Color.Red),
            new BcColor("橙色",Color.Orange),
            new BcColor("黄色",Color.Yellow),
            new BcColor("绿色",Color.Green),
            new BcColor("青色",Color.Cyan),
            new BcColor("蓝色",Color.Blue),
            new BcColor("紫色",Color.Purple),

         ]);
        // 下拉框初始化
        //ColorList.ConvertAll(item => item.Name).ToArray();

        BackColorCb.Items.AddRange(ColorList.ConvertAll(item => item.Name).ToArray());


        BackColorCb.SelectedIndexChanged += Change;
    }
    private void Change(object sender,EventArgs e)
    {
        string name = (sender as ComboBox).SelectedItem.ToString();

        Color c = ColorList.Find(item => item.Name == name)._Color;

        this.BackColor = c;

    }
}
```



![](./assets/下拉框换皮肤.gif)

### 全选反选

```C#

        public Form4()
        {
            InitializeComponent();
            // 复选框- 选中改变事件
            AllCbox.CheckStateChanged += AllChanged;

            // 给所有的 单个复选框 绑定事件 CheckedChanged
            foreach (Control ItemBox in ChildPan.Controls) (ItemBox as CheckBox).CheckedChanged += ItemChanged;

        }

        private void ItemChanged(object sender, EventArgs e)
        {
            //  OfType<> 过滤方法得到一个只有Control类型的集合
            List<Control> childList = ChildPan.Controls.OfType<Control>().ToList();

            // 判断是否所有都选中  list中的 TrueForAll
            bool isAll = childList.All(item => (item as CheckBox).Checked);
            // 判断是否有选中 (至少一个选中) Some
            bool isAny = childList.Any(item => (item as CheckBox).Checked);

            // 给AllCbox 设置的状态有三种
            if (isAll)
            {
                AllCbox.CheckState = CheckState.Checked;
            }
            else
            {
                if (isAny)
                {
                    AllCbox.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    AllCbox.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void AllChanged(object sender, EventArgs e)
        {

            // 获取当前全选按钮的状态
            //MessageBox.Show(AllCbox.Checked.ToString());
            bool isCheck = AllCbox.CheckState == CheckState.Checked ? true : false;
            if (AllCbox.CheckState != CheckState.Indeterminate) { // 如果半选则 不改其他内容
                // 遍历 
                foreach (Control ItemBox in ChildPan.Controls)
                {
                    (ItemBox as CheckBox).Checked = isCheck;
                }
            }
            
        }
```



![](./assets/全选反选.gif)

### 拖拽

![](./assets/拖拽.gif)

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

![1786268316238](./assets/1786268316238.png) 

输入窗体名称：

![1786268382957](./assets/1786268382957.png) 

然后就看到新建的窗体了：

![1786268406333](./assets/1786268406333.png) 



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



## 四、第三方库

winform默认布局的控件，相对来说是比较丑的。有些开源库，里面将默认的控件，做了封装，变得漂亮，我们可以使用这种开源的库，对界面进行布局。

### 下载安装：

在解决方案下面文件夹上右击：

![1786609614377](assets/1786609614377.png) 

![1786609710748](assets/1786609710748.png) 

![1786609754042](assets/1786609754042.png) 

![1786609812770](assets/1786609812770.png) 

![1786609841880](assets/1786609841880.png) 

![1786609862943](assets/1786609862943.png) 

![1786609926689](assets/1786609926689.png) 

AntdUI使用的时候，跟默认的控件使用方式是一样的。

参考网站：https://gitee.com/AntdUI/AntdUI/blob/main/doc/wiki/zh/Control/Input.md



### 图书新增界面

![1786611556248](assets/1786611556248.png) 





## 作业

 二级联动中数据组织方式将原来的list改为字典 实现

```C#
  {
    ["省份"]=["城市","城市",....],
    .....    
  }
```

