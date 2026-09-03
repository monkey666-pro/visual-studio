# day10

## 一、菜单控件

### 1、菜单栏

winform窗体可以设置顶部菜单，使用MenuStrip控件：

![1786882166998](assets/1786882166998.png) 

效果：

![1786882204847](assets/1786882204847.png) 

![1786882224253](assets/1786882224253.png) 

添加快捷键，通常菜单栏的快捷键是Alt组合键，只需要在文本属性后添加小括号，小括号中使用`&字符`就可以：

 ![1786882838274](assets/1786882838274.png) 

效果：

![1786882872789](assets/1786882872789.png) 

可以添加图标：

鼠标右击菜单，选择"编辑项"

![1786883160174](assets/1786883160174.png) 

导入图标资源：

![1786883181787](assets/1786883181787.png) 

确定后就能看到效果了。

效果：

![1786883115146](assets/1786883115146.png) 

### 2、工具栏

工具栏指的是菜单栏下面的图标一栏。工具栏用的是ToolStrip控件：

![1786883260469](assets/1786883260469.png) 

在设计器中，工具栏可以是按钮、文本、下拉框、分割线等形式：

![1786883501778](assets/1786883501778.png) 

## 二、文件选择和保存文件

### 1、文件选择

我们在winform窗口中可以像上传文件一样，打开文件并选择，使用`c#`提供的OpenFileDialog类。使用步骤：

- 创建对象

  ```c#
  OpenFileDialog OFD = new OpenFileDialog();
  ```

  

- 配置属性：弹窗标题、文件过滤器、默认打开的文件夹

  ```c#
  OFD.Title = "请选择文件"; // 弹窗标题
  OFD.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"; // 文件筛选器
  OFD.InitialDirectory = Application.StartupPath; // 默认打开程序所在文件夹
  openDlg.Multiselect = true; // 开启多文件选择
  ```

  > Filter 文件过滤器（格式必须严格）：
  >
  > 格式规则：显示名称|后缀;后缀|显示名称|后缀

  可配置的选项：

  > Multiselect：是否开启多选
  >
  > Title：对话框标题
  >
  > InitialDirectory：默认打开文件夹
  >
  > RestoreDirectory：是否记住上次打开的文件夹
  >
  > FilterIndex：默认选中第几个文件过滤器

- 通过判断后获取选择的文件路径

  ```c#
  if (OFD.ShowDialog() == DialogResult.OK)
  {
      // 获取选中文件完整路径
      string filePath = OFD.FileName;
      MessageBox.Show("你选中的文件：" + filePath);
      // 有了文件路径后，如果是文本文件可以读取，图片可以设置在PictureBox中
  }
  ```

  > 读取内容的属性：
  >
  > `FileName`：单选时获取选中文件完整路径
  >
  > `FileNames`：多选时，string [] 数组，必须开启 Multiselect

- 关闭文件，释放资源，否则文件打开这个操作一直进行

  ```c#
  openDlg.Dispose(); // 释放资源，或者用using自动释放
  ```

使用using语法可以不用手动关闭文件释放，自动会释放：

```c#
using (OpenFileDialog openDlg = new OpenFileDialog()){}
```

### 2、保存文件

我们可以弹出窗口让用户选择保存路径、输入文件名称。

```c#
using (SaveFileDialog SFD = new SaveFileDialog())
{
    SFD.RestoreDirectory = false;
    SFD.Filter = "文本|*.txt";
    SFD.InitialDirectory = Application.StartupPath;
    if (SFD.ShowDialog() == DialogResult.OK)
    {
        File.WriteAllText(SFD.FileName, "123");
    }
}
```

> 属性：
>
> `Title`：对话框窗口标题
>
> `FileName`：获取 / 设置默认文件名（包括后缀）
>
> `Filter`：文件过滤器，格式：`文本文件 (*.txt)|*.txt`
>
> `FilterIndex`：默认选中的过滤器索引，从1 开始
>
> `InitialDirectory`：对话框打开时的初始文件夹路径
>
> `DefaultExt`：默认文件扩展名，不带`.`，例 `"txt"`，要配合AddExtension使用
>
> `AddExtension`：是否自动追加默认扩展名，true：输入文件名不带后缀自动补上 DefaultExt
>
> `OverwritePrompt = true`（默认开启）：文件存在时自动弹出 “是否覆盖” 提示

### 3、选择文件夹

```c#
using (FolderBrowserDialog FBD = new FolderBrowserDialog())
{
    FBD.Description = "选择目录";
    FBD.SelectedPath = Application.StartupPath;
    if(FBD.ShowDialog() == DialogResult.OK)
    {
        MessageBox.Show(FBD.SelectedPath);
    }
}
```

> `SelectedPath`：选中文件夹完整路径
>
> `Description`：对话框说明文字

## 三、Timer控件

定时器：让一个函数中的代码段，每隔一段时间就执行一次，不停的执行下去。

```c#
private System.Windows.Forms.Timer MyTimer { get; set; }
public Form1()
{
    InitializeComponent();
    // 实例化Timer
    MyTimer = new System.Windows.Forms.Timer();
    // 执行间隔时间
    MyTimer.Interval = 20;
    // 执行的函数
    MyTimer.Tick += Timer_Tick;
    // 开始执行
    MyTimer.Start();
}
private void Timer_Tick(object sender, EventArgs e)
{
    label1.Text = DateTime.Now.ToString();
    label1.Left += 1;
    if (label1.Left >= 200)
    {
        // 停止定时器
        MyTimer.Stop();
    }
}
```

作业：动态的距离国庆的倒计时（几天几小时）





## 四、数据绑定

我们要说的数据绑定，是实现数据和控件双向变化，控件和数据之间的绑定模式。

例如：我们将一个类的实例对象中的name属性跟TextBox的Text属性进行绑定，那么当name属性值发生改变的时候，TextBox的Text会自动跟着发生改变；当TextBox的Text属性发生变化的时候，name属性的值也会跟着发生改变。

再复杂一点的话，我们可以将一个数据跟一个复杂控件进行绑定，就不仅仅是控件的一个属性了。 

### 1、简单绑定

简单绑定指的是让某个控件的一个属性跟数据源进行绑定。支持这种绑定方式的控件有：TextBox、Label、CheckBox 这类单个值的控件。

绑定关键：数据源必须是一个类的实例对象，类必须实现INotifyPropertyChanged这个接口，绑定时是让控件的某个属性跟对象的某个属性进行双向绑定的。

绑定语法：

```c#
控件.DataBindings.Add(控件属性, 类的实例对象, 对象的属性);
```

例：

类的实现：

```c#
internal class BindData : INotifyPropertyChanged
{
	// 必须实现的接口中的事件，固定语法
    public event PropertyChangedEventHandler PropertyChanged;
    private string _TextBoxData { get; set; } = "文本框初始值";
    public string TextBoxData
    {
        get
        {
            return _TextBoxData;
        }
        set
        {
            _TextBoxData = value;
            // 固定语法，通知控件更新
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextBoxData)));
        }
    }
}
```

绑定语法：

```c#
private BindData Bd { get; set; }
public Form1()
{
    InitializeComponent();

    Bd = new BindData();
    textBox1.DataBindings.Add("Text", Bd, "TextBoxData");
    label1.DataBindings.Add("Text", Bd, "LabelData");
}

private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show(Bd.TextBoxData);
}

private void button2_Click(object sender, EventArgs e)
{
    Bd.TextBoxData = textBox2.Text;
}
```

效果：

![](assets/简单绑定.gif) 



### 2、复杂绑定

复杂绑定是将整个控件的数据和数据源绑定在一起，实现双向绑定，数据源变，控件数据显示变；控件数据变，数据源也变。支持这种方式绑定数据的控件有：DataGridView、ListBox、ComboBox，绑定一整个列表。

支持绑定控件的数据源可以是：`List<T>`、`BindingList<T>`、`DataTable`。

绑定关键：

- `List<T>`代码里 `list.Add()`、`list.Remove()`，表格界面不会自动新增 / 删除行。但是单元格编辑可以同步回对象属性（如果对象实现 INotifyPropertyChanged）
- `BindingList<T>`实现集合变更通知，增删集合，UI 自动刷新

例：

类的实现：

```c#
internal class BindListData : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private string _BookName {  get; set; }
    public string BookName
    {
        get
        {
            return _BookName;
        }
        set
        {
            _BookName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BookName)));
        }
    }
    private double _BookPrice {  get; set; }
    public double BookPrice
    {
        get
        {
            return _BookPrice;
        }
        set
        {
            _BookPrice = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BookPrice)));
        }
    }
}
```

绑定：

```c#
//private List<BindListData> ListTable = new List<BindListData>();
private BindingList<BindListData> ListTable = new BindingList<BindListData>();
public ListBindData()
{
    InitializeComponent();
    ListTable.Add(new BindListData
    {
        BookName = "三国演义",
        BookPrice = 19.99
    });
    ListTable.Add(new BindListData
    {
        BookName = "水浒传",
        BookPrice = 23.89
    });
    ListTable.Add(new BindListData
    {
        BookName = "西游记",
        BookPrice = 65.88
    });

    dataGridView1.DataSource = ListTable;
    DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
    colEdit.Name = "colDel";
    colEdit.HeaderText = "操作";
    colEdit.Text = "删除";
    colEdit.UseColumnTextForButtonValue = true; //所有单元格显示这个文字
    colEdit.Width = 60;
    dataGridView1.Columns.Add(colEdit);
    dataGridView1.CellClick += dataGridView1_CellClick;
}
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    //排除表头点击，e.RowIndex<0就是点表头
    if (e.RowIndex < 0) return;

    //点击的列名
    string colName = dataGridView1.Columns[e.ColumnIndex].Name;

    //获取当前行绑定的数据，假设实体是Book
    //Book book = dataGridView1.Rows[e.RowIndex].DataBoundItem as Book;

    //获取主键ID，从单元格拿，或者DataBoundItem拿
    //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

    if (colName == "colDel")
    {
        //MessageBox.Show($"点击编辑，id={id}");
        //打开编辑窗体，把id传过去
        if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            //执行删除逻辑，刷新表格
            ListTable.RemoveAt(e.RowIndex);
        }
    }
}
private void button1_Click(object sender, EventArgs e)
{
    string ShowDataStr = "";
    foreach (var item in ListTable)
    {
        ShowDataStr += $"书名：{item.BookName};;书价：{item.BookPrice}\n";
    }
    MessageBox.Show(ShowDataStr);
}

private void button2_Click(object sender, EventArgs e)
{
    ListTable[0].BookName = "石头记";
}

private void button3_Click(object sender, EventArgs e)
{
    ListTable.Add(new BindListData
    {
        BookName = "红楼梦",
        BookPrice = 67.99
    });
}
```

效果：

![](assets/复杂绑定.gif) 



## 五、DataGridView

### 1、基础配置

```c#
// 禁止用户自动新增空白行
dataGridView1.AllowUserToAddRows = false;
// 禁止删除行
dataGridView1.AllowUserToDeleteRows = false;
// 禁止调整列宽
dataGridView1.AllowUserToResizeColumns = true;
// 行是否可调高度
dataGridView1.AllowUserToResizeRows = true;

// 选择模式
dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 整行选中
// 只能选一行
dataGridView1.MultiSelect = false;

// 只读，不让单元格编辑
dataGridView1.ReadOnly = true;

// 表头是否可见
dataGridView1.ColumnHeadersVisible = true;
dataGridView1.RowHeadersVisible = true;
```

### 2、列操作

```c#
// 根据索引隐藏列
dataGridView1.Columns[0].Visible = false;
// 根据名字隐藏
dataGridView1.Columns["colId"].Visible = false;

// 设置列宽
dataGridView1.Columns["colId"].Width = 80;
// 自动适配宽度
dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

// 删除某一列
dataGridView1.Columns.Remove("colId");
```

### 3、列设置

```c#
DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
colEdit.Name = "colDel";
colEdit.HeaderText = "操作";
colEdit.Text = "删除";
colEdit.UseColumnTextForButtonValue = true; //所有单元格显示这个文字
colEdit.Width = 60;
dataGridView1.Columns.Add(colEdit);
```

### 4、行操作

```c#
// 添加空行
int idx = dataGridView1.Rows.Add();

// 删除指定行
dataGridView1.Rows.RemoveAt(0);

// 清空所有行
dataGridView1.Rows.Clear();
```

### 5、单元格操作

```c#
// 读：行索引，列索引
object val = dataGridView1.Rows[0].Cells[1].Value;

// 写
dataGridView1.Rows[0].Cells[1].Value = "新值";
```

### 6、获取选中项

```c#
// 绑定模式
if(_bsBook.Current is Book book)
{
    int id = book.Id;
    string name = book.BookName;
}
// 非绑定模式
if(dataGridView1.CurrentRow != null)
{
    // 取单元格
    string name = dataGridView1.CurrentRow.Cells["BookName"].Value?.ToString();
}
// 多选
foreach(DataGridViewRow row in dataGridView1.SelectedRows)
{
    var id = row.Cells["Id"].Value;
}
```

### 7、事件

```c#
// 单元格点击
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    // e.RowIndex 行号，e.ColumnIndex列号
    if(e.RowIndex >= 0)
    {
        var row = dataGridView1.Rows[e.RowIndex];
    }
}
// 切换选中行
private void dataGridView1_SelectionChanged(object sender, EventArgs e)
{
    // 行切换就会触发
}
// 单元格编辑完成
private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
{
    // 用户修改单元格之后执行
}
// 绑定格式错误
private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
{
    // 比如文本输入不能转decimal，捕获异常，不让弹出讨厌的默认错误框
    e.ThrowException = false;
    MessageBox.Show("输入格式不正确");
}
```

### 8、表头和隔行换色

```c#
// 隔行变色
dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
// 表头背景
dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
```





