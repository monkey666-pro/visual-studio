---
typora-copy-images-to: assets
---

# day13

## 一、递归函数

概念：在函数中调用当前函数，形成一种循环调用的场景。

例：

```c#
public void Digui() {
    Digui(); // 死循环递归会造成内存溢出
}
public static Main() {
    Digui();
}
```

递归函数注意：在函数中要有停止的条件，让这个函数能停下来。

例：定义一个递归函数，用来求某个数字的阶和，5==>5+4+3+2+1

```c#
static void Main(string[] args)
{
    int sum = Digui(5);
    Console.WriteLine(sum); // 15
}
// 功能：求某个数字的阶和。 5的阶和=5+4的阶和；4的阶和=4+3的阶和；3的阶和=3+2的阶和；2的阶和=2+1的阶和
public static int Digui(int num)
{
    if (num == 1)
    {
        return 1;
    }
    // num的阶和=num+(num-1)的阶和
    return num + Digui(num - 1);
}
```

分析上述函数的执行流程：

> Main中调用Digui(5)开始执行递归函数：
>
> ```c#
> if (num == 1) // false
> {
>     return 1;
> }
> return num + Digui(num - 1); // return 5 + Digui(4)// 4 + 3 + 2 +1
> ```
>
> 函数中调用了Digui(4)，函数再次执行：
>
> ```c#
> if (num == 1) // false
> {
>     return 1;
> }
> return num + Digui(num - 1); // return 4 + Digui(3) // 3 + 2 +1
> ```
>
> 函数中调用了Digui(3)，函数再次执行：
>
> ```c#
> if (num == 1) // false
> {
>     return 1;
> }
> return num + Digui(num - 1); // return 3 + Digui(2)
> ```
>
> 函数中调用了Digui(2)，函数再次执行：
>
> ```c#
> if (num == 1) // false
> {
>     return 1;
> }
> return num + Digui(num - 1); // return 2 + Digui(1)
> ```
>
> 函数中调用了Digui(1)，函数再次执行：
>
> ```c#
> if (num == 1) // true
> {
>     return 1;
> }
> return num + Digui(num - 1); // return 2 + Digui(1)
> ```
>
> Digui(1)有了结果是1，Digui(2)就有了结果：2+1，Digui(2)有了结果，Digui(3)的结果就是：3+2+1；然后Digui(4)的结果就是：4+3+2+1；最终，Digui(5)的结果就是：5+4+3+2+1

例：斐波那契数列

一组有规律的数字：`1 1 2 3 5 8 13 21 34 55 ....`

> 第一个和第二个数字都是1;  第三个数字开始 每个数字是前两个数字的和

定义一个递归函数，求第n个数字是多少？

```c#
static void Main(string[] args)
{
    // 求斐波那契数列中第10个数字是几
    //int result = Feibo(10);
    //Console.WriteLine(result); // 55

    int result = Feibo(5);
    Console.WriteLine(result); // 5
}
// 功能：求斐波那契数列中第n个数字是多少。
public static int Feibo(int num)
{
    if (num == 1)
    {
        return 1;
    }
    if (num == 2)
    {
        return 1;
    }
    // num位置上的数字就是：num-1位置上的数字 + num-2位置上的数字
    return Feibo(num - 1) + Feibo(num - 2);
}
```

> 分析：
>
> Feibo(5)结果是：Feibo(4) + Feibo(3)
>
> - 求Feibo(4)的结果
>   - Feibo(3)
>     - Feibo(2) ==> 1
>     - Feibo(1) == >1
>   - Feibo(2) ==> 1
> - Feibo(3)的结果
>   - Feibo(2) ==> 1
>   - Feibo(1) ==> 1

例：求`1-1/2+1/3-1/4+1/5 ... -1/100`的结果

```c#
static void Main(string[] args)
{
    // 求1-1/2+1/3-1/4+1/5 ... -1/100的结果
    double result = GetSum(100);
    Console.WriteLine(result);
}
//求`1-1/2+1/3-1/4+1/5 ... -1/100`的结果
public static double GetSum(double num)
{
    if (num == 1)
    {
        return 1;
    }
    double a;
    // 判断奇数偶数
    if (num % 2 == 1)
    {
        a = 1 / num;
    } else
    {
        a = -1 / num;
    }
    return a + GetSum(num - 1);
}
```

## 二、打字游戏

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class PressWord : Form
    {
        // 定义label的高度
        private int LbHeight = 0;
        // 第几个label
        private int Times = 0;
        // 定义label
        private System.Windows.Forms.Label Lb = new System.Windows.Forms.Label();
        public PressWord()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer WordTimer;

        private void button1_Click(object sender, EventArgs e)
        {
            LbHeight = 0;
            CreateWord();
            // 开始游戏
            WordTimer = new System.Windows.Forms.Timer();
            WordTimer.Interval = 20;
            WordTimer.Tick += GameStart;
            WordTimer.Start();
            this.KeyPreview = true;               // 确保窗体先收到按键
            this.ActiveControl = null;            // 移走焦点
            this.KeyUp -= PressWordStart;         // 避免重复订阅
            this.KeyUp += PressWordStart;
        }
        private void PressWordStart(object sender, EventArgs e)
        {
            KeyEventArgs ev = e as KeyEventArgs;
            if (ev == null) return;
            // 将label中的字符转成枚举类型Keys，方便判断
            if (!Enum.TryParse<System.Windows.Forms.Keys>(Lb.Text, true, out var K)) return;
            
            if (K == ev.KeyCode)
            {
                panel1.Controls.Remove(Lb);
                LbHeight = 0;
                CreateWord();
            }
        }
        private void GameStart(object sender, EventArgs e)
        {
            LbHeight += 2;
            Lb.Top = LbHeight;
            if (Lb.Top >= panel1.Height - 30)
            {
                WordTimer.Stop();
                MessageBox.Show("GAME OVER!!!");
                panel1.Controls.Remove(Lb);
            }
        }
        private void CreateWord()
        {
            // 创建所有字母字符串
            string AllWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 创建随机下标
            Random Rand = new Random();
            int index = Rand.Next(AllWords.Length);
            // 获取随机字符
            char Word = AllWords[index];
            // 创建label
            Lb.AutoSize = false;
            Lb.TextAlign = ContentAlignment.MiddleCenter;
            Lb.Size = new Size(30, 30);
            Lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            // 创建随机x坐标
            int LbX = Rand.Next(panel1.Width - 30);
            Lb.Location = new Point(LbX, LbHeight);
            Lb.Name = "label" + Times;
            Lb.Text = Word.ToString();
            panel1.Controls.Add(Lb);
            Times++;
        }
    }
}

```

V2：

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WordGameV2 : Form
    {
        public WordGameV2()
        {
            InitializeComponent();
            // 将核心代码放在Shown事件中
            this.Shown += WordGameV2_Shown;
        }

        private void WordGameV2_Shown(object? sender, EventArgs e)
        {
            // 按钮点击事件
            button1.Click += Button1_Click;
        }
        // 定义定时器
        private System.Windows.Forms.Timer GlobalTimer = new System.Windows.Forms.Timer();
        private void Button1_Click(object? sender, EventArgs e)
        {
            // 核心代码：
            /*
            使用一个定时器，每隔一会就生成一个新的lb，让他下落
            给窗体绑定键盘事件
            */
            // 设置timer
            GlobalTimer.Interval = 3000;
            GlobalTimer.Tick += GlobalTimer_Tick;
            GlobalTimer.Start();
            // 移动焦点
            this.KeyPreview = true;
            // 绑定键盘事件
            this.KeyUp += WordGameV2_KeyUp;
        }
        private int Score = 0;
        private void WordGameV2_KeyUp(object? sender, KeyEventArgs e)
        {
            // 敲键盘：遍历所有的label，跟当前敲键盘的字符判断是否相等
            for (int i = 0; i < LbAndTimer.Count; i++)
            {
                // 每个label LbAndTimer[i].label
                bool IsParsed = Enum.TryParse(LbAndTimer[i]["label"].Text, out Keys K);
                if (!IsParsed)
                {
                    continue;
                }
                if (K == e.KeyCode)
                {
                    // 敲中这个label了，删除label，停止他对应的timer
                    panel1.Controls.Remove(LbAndTimer[i]["label"]);
                    LbAndTimer[i]["timer"].Stop();
                    Score++;
                    label2.Text = Score.ToString();
                    break;
                }
            }
        }

        // 随机数对象
        private Random Rand = new Random();
        // 定义集合，用来存储label和timer的对应关系，所有的label对应所有的timer
        private List<Dictionary<string, dynamic>> LbAndTimer = new List<Dictionary<string, dynamic>>();
        private void GlobalTimer_Tick(object? sender, EventArgs e)
        {
            // 创建label
            Label Lb = CreateLabel();
            // 让label下落
            System.Windows.Forms.Timer LabelTimer = new System.Windows.Forms.Timer();
            LabelTimer.Interval = 20;
            // 将这个label和timer放在一个字典中，将这个字典放在list中
            LbAndTimer.Add(new Dictionary<string, dynamic>()
            {
                ["label"] = Lb,
                ["timer"] = LabelTimer
            });
            LabelTimer.Tick += (object? sender, EventArgs e) => {
                LabelMoveDown(Lb);
            };
            LabelTimer.Start();
        }

        private void LabelMoveDown(Label Lb)
        {
            // 让label每次都向下移动一点距离
            Lb.Top += 2;
            if (Lb.Top >= panel1.Height - 30)
            {
                Lb.Top = panel1.Height - 30;
                // 让所有的timer都停下来
                foreach(var item in LbAndTimer)
                {
                    item["timer"].Stop();
                }
                GlobalTimer.Stop();
                MessageBox.Show("GAME OVER!!!");
            }
        }

        // 创建label
        private Label CreateLabel()
        {
            // 创建label
            Label Lb = new Label();
            Lb.AutoSize = false;
            Lb.Size = new Size(30, 30);
            Lb.Location = new Point(Rand.Next(panel1.Width - 30), 0);
            Lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Lb.TextAlign = ContentAlignment.MiddleCenter;
            Lb.Text = CreateRandomWord();
            panel1.Controls.Add(Lb);
            return Lb;
        }
        // 生成随机字符
        private string CreateRandomWord()
        {
            // 获取随机的大写字母的阿斯克码值
            int Ascm = Rand.Next(65, 91);
            // 将阿斯克码值转成字符
            char Word = (char)Ascm;
            return Word.ToString();
        }
    }
}
```

