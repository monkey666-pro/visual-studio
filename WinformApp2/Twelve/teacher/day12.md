---
typora-copy-images-to: assets
---

# day12

## 画图

理解：

1. winform内置了画图的api支持
2. 画图程序必须运行某个控件的在Paint事件中
3. 画图步骤
   1. 获取画图对象
   2. 设置画图配置（不是必须的）
   3. 创建画笔或笔刷
   4. 画指定图形

例：在Form窗体上画一个矩形

```c#
private void Form1_Shown(object? sender, EventArgs e)
{
    this.Paint += Panel1_Paint;
}
private void Panel1_Paint(object? sender, PaintEventArgs e)
{
    // 获取画图对象
    Graphics g = e.Graphics;
    // 配置抗锯齿
    g.SmoothingMode = SmoothingMode.AntiAlias;
    // 创建画笔，红色，宽度2
    using (Pen penRed = new Pen(Color.Red, 2))
    {
        // 画矩形，开始坐标、大小
        g.DrawRectangle(penRed, 10, 10, 120, 80);
    }
}
```

效果：

![1787740160349](assets/1787740160349.png) 

### 1、画矩形

```c#
//1. 画空心矩形：画笔Pen，红色，宽度2像素
using (Pen penRed = new Pen(Color.Red, 2))
{
    g.DrawRectangle(penRed, 10, 10, 120, 80);
}
```

### 2、画填充矩形

```c#
//2. 画实心填充矩形：画刷Brush
using (Brush brushBlue = new SolidBrush(Color.FromArgb(80, 0, 120, 255)))//半透明蓝色
{
    g.FillRectangle(brushBlue, 150, 10, 120, 80);
}
```

### 3、画空心圆

```c#
//3. 画圆形（椭圆，宽高相等就是圆）
using (Pen penGreen = new Pen(Color.Green, 2))
{
    g.DrawEllipse(penGreen, 10, 110, 100, 100);
}
```

### 4、画直线

```c#
//4. 画直线
g.DrawLine(Pens.Orange, 130, 110, 250, 210);
```

### 5、画文字

```c#
//5. 画文字
using (Brush brushText = new SolidBrush(Color.Black))
using (Font font = new Font("微软雅黑", 12))
{
    g.DrawString("GDI+测试文字", font, brushText, 270, 20);
}
// 文字对齐方式
using (StringFormat sf = new StringFormat()){
    sf.Alignment = StringAlignment.Center;
    sf.LineAlignment = StringAlignment.Center;
    g.DrawString("文本", font, brushText, x坐标, y坐标, sf);
}
```

### 6、画多边形（比如ROI四边形）

```c#
//6. 画多边形（比如ROI四边形）
Point[] points =
{
    new Point(300,20),
    new Point(380,40),
    new Point(360,120),
    new Point(280,100)
};
using (Pen penPoly = new Pen(Color.DarkMagenta, 2))
{
    g.DrawPolygon(penPoly, points);
}
```

### 7、画实心圆

```c#
// 创建画笔，红色，宽度2
using (SolidBrush brushRed = new SolidBrush(Color.Red))
{
    // x,y：圆外接矩形左上角；半径30 → 宽=60，高=60
    g.FillEllipse(brushRed, 20, 20, 60, 60);
}
```

### 8、画三角形

```c#
// 三个顶点：上、左下、右下
Point[] triPoints =
{
    new Point(100,30),   //顶点1 顶部
    new Point(50,120),   //顶点2 左下角
    new Point(150,120)   //顶点3 右下角
};
// 空心
using(Pen pen=new Pen(Color.Black,2))
{
    g.DrawPolygon(pen, triPoints);
}
// 实心
using (SolidBrush brush = new SolidBrush(Color.DarkRed))
{
    g.FillPolygon(brush, triPoints);
}
```

例：正三角形

```c#
int radius = 100;
int cx = 100;
int cy = 100;
Point[] pts = new Point[3];
// 三个角度，0°、120°、240°
double[] angles = { 270, 30, 150 };

for (int i = 0; i < 3; i++)
{
    double rad = angles[i] * Math.PI / 180;
    int x = cx + (int)(radius * Math.Cos(rad));
    int y = cy + (int)(radius * Math.Sin(rad));
    pts[i] = new Point(x, y);
}
// using(Pen p = new Pen(Color.Red))
using (SolidBrush brush = new SolidBrush(color))
{
    g.FillPolygon(brush, pts);
    // g.DrawEllipse(p, 0, 0, 200, 200);
}
```

补充颜色透明：

```c#
Color.FromArgb(20, 255, 0, 0) // 透明度（0-255，r，g，b）
```

### 9、画弧线

```c#
Rectangle Rect = new Rectangle(x开始坐标, y开始坐标, 长, 高);
g.DrawArc(画笔, Rect, 开始角度, 弧线范围角度);
```

### 10、panel闪烁解决

定义一个双缓冲类，继承自panel：

```c#
public class DoubleBufferPanel : Panel
{
    public DoubleBufferPanel()
    {
        //开启双缓冲，消除闪烁
        this.SetStyle(ControlStyles.UserPaint
            | ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer, true);
        UpdateStyles();
    }
}
```

我们定义的panel控件，换成这个类：

```c#
//panel1 = new Panel();
panel1 = new DoubleBufferPanel();
```

当需要重绘的时候：

```c#
panel1.Invalidate();
```

原理解释：

每当我们需要重绘的时候，默认Windows 会先用背景色把屏幕上 Panel 区域直接抹白，这一步直接输出到屏幕，眼睛看到一闪。（AllPaintingInWmPaint的作用）

OptimizedDoubleBuffer的作用：创建内存画布，所有绘制操作，都放在内存中，跟屏幕无关，等绘制函数执行结束所有图形全部在内存绘制完成，一次性将内存画布拷贝到屏幕。

钟表案例：

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1
{
    public partial class Clock : Form
    {
        private System.Windows.Forms.Timer SecondTimer = new System.Windows.Forms.Timer();
        public Clock()
        {
            InitializeComponent();

            // 获取当前秒数给Num实际的值
            DateTime Now = DateTime.Now;
            Num = Now.Second;
            // 要在panel中画画，就需要给panel绑定Paint事件
            panel1.Paint += Panel1_Paint;
            // 设置定时器函数
            SecondTimer.Interval = 1000;
            SecondTimer.Tick += SecondTimer_Tick;
            SecondTimer.Start();
        }

        private void SecondTimer_Tick(object? sender, EventArgs e)
        {
            Num++;
            // 让画图程序重新画一次
            panel1.Invalidate();
        }

        // 定义数据
        // 圆心
        private int RadiusX = 150;
        private int RadiusY = 150;
        // 半径
        private int Radius = 100;
        // 每条线的初始和结尾坐标
        private int LineStartX = 250;
        private int LineStartY = 150;
        private int LineEndX = 150 + 80;
        private int LineEndY = 150;
        // 12个刻度的长度
        private int LongScale = 10;
        // 刻度线数量
        private int ScaleCount = 60;
        // 当前秒数
        private int Num = 0;
        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            // 创建对象
            var g = e.Graphics;
            // 抗锯齿
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // 画空心圆
            using (var pen = new Pen(Color.Black, 2))
            {
                // 画圆
                g.DrawArc(pen, 50, 50, 200, 200, 0, 360);

                // 画刻度线
                //// 画第一条线
                //g.DrawLine(pen, LineStartX, LineStartY, LineEndX, LineEndY);

                //// 画第二条线
                //// 计算第二条线的开始坐标
                //var StartX2 = Math.Cos(30 * Math.PI / 180) * Radius + RadiusX;
                //var StartY2 = Math.Sin(30 * Math.PI / 180) * Radius + RadiusY;

                //var EndX2 = Math.Cos(30 * Math.PI / 180) * (Radius - 10 - 10) + RadiusX;
                //var EndY2 = Math.Sin(30 * Math.PI / 180) * (Radius - 10 - 10) + RadiusY;
                //g.DrawLine(pen, (int)StartX2, (int)StartY2, (int)EndX2, (int)EndY2);

                //// 画第三条线
                //// 计算第三条线的开始坐标
                //var StartX3 = Math.Cos(2*30 * Math.PI / 180) * Radius + RadiusX;
                //var StartY3 = Math.Sin(2*30 * Math.PI / 180) * Radius + RadiusY;

                //var EndX3 = Math.Cos(2*30 * Math.PI / 180) * (Radius - 10 - 10) + RadiusX;
                //var EndY3 = Math.Sin(2*30 * Math.PI / 180) * (Radius - 10 - 10) + RadiusY;
                //g.DrawLine(pen, (int)StartX3, (int)StartY3, (int)EndX3, (int)EndY3);

                // 定义每个角度
                var EveryDeg = 360 / ScaleCount;
                // 循环处理12条线
                for (int i = 0; i < ScaleCount; i++)
                {
                    var TempScale = LongScale;
                    // 判断12个刻度线长一点
                    if (i % 5 == 0)
                    {
                        TempScale = LongScale + 10;
                    }

                    var StartX = Math.Cos(i * EveryDeg * Math.PI / 180) * Radius + RadiusX;
                    var StartY = Math.Sin(i * EveryDeg * Math.PI / 180) * Radius + RadiusY;

                    var EndX = Math.Cos(i * EveryDeg * Math.PI / 180) * (Radius - TempScale) + RadiusX;
                    var EndY = Math.Sin(i * EveryDeg * Math.PI / 180) * (Radius - TempScale) + RadiusY;
                    g.DrawLine(pen, (int)StartX, (int)StartY, (int)EndX, (int)EndY);
                }

                // 画秒针
                using (var SecondLine = new Pen(Color.Red, 2))
                {
                    var SecondStartX = Math.Cos((Num * 6 + 270) * Math.PI / 180) * Radius + RadiusX;
                    var SecondStartY = Math.Sin((Num * 6 + 270) * Math.PI / 180) * Radius + RadiusY;
                    g.DrawLine(SecondLine, (int)SecondStartX, (int)SecondStartY, RadiusX, RadiusY);
                }
            }
        }
    }


    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}


// 界面设计文件Clock.designer.cs将panel改成DoubleBufferPanel
```

半圆表盘案例：

```c#
using System.Drawing.Drawing2D;
using System.Timers;
using static System.Windows.Forms.AxHost;

namespace MyYBP
{
    public partial class Form1 : Form
    {
        private int ShortLineStartX = 0;
        private int ShortLineStartY = 0;
        private int ShortLineEndX = 0;
        private int ShortLineEndY = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            panel1.Paint += Panel1_Paint;
            // 刻度初始x、y
            ShortLineStartX = RX + R;
            ShortLineEndX = RX + R - ShortLine;
            ShortLineEndY = RY;
            ShortLineStartY = RY;
            MyTimer.Interval = 2000;
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Start();
        }

        private void MyTimer_Tick(object? sender, EventArgs e)
        {
            CurrentTemp++;
            panel1.Invalidate();
        }

        private int RX = 240;
        private int RY = 180;
        private int R = 60;
        private int ShortLine = 10;
        private int ShortLineCount = 30;
        private int CurrentTemp = 20;
        private double EveryDeg = 6;
        private double EveryTemp = 2;
        private System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            // 获取画图对象
            Graphics g = e.Graphics;
            // 配置抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;

            
            using (Pen penGreen = new Pen(Color.Green, 2))
            {
                Rectangle Rect = new Rectangle(RX - R, RY - R, R * 2, R * 2);
                g.DrawArc(penGreen, Rect, 180, 180);
                for (int i = 0; i <= 30; i++)
                {
                    var LineLength = ShortLine;
                    if (i % 10 == 0)
                    {
                        LineLength = ShortLine + 5;
                    }
                    var StartX = RX + Math.Cos((180 + EveryDeg * i) * Math.PI / 180) * R;
                    var StartY = RY + Math.Sin((180 + EveryDeg * i) * Math.PI / 180) * R;
                    var EndX = RX + Math.Cos((180 + EveryDeg * i) * Math.PI / 180) * (R - LineLength);
                    var EndY = RY + Math.Sin((180 + EveryDeg * i) * Math.PI / 180) * (R - LineLength);
                    
                    g.DrawLine(Pens.Orange, (int)StartX, (int)StartY, (int)EndX, (int)EndY);
                    
                    if (i % 10 == 0)
                    {
                        using (Brush brushText = new SolidBrush(Color.Black))
                        using (StringFormat sf = new StringFormat())
                        using (Font font = new Font("微软雅黑", 8))
                        {
                            /*
                                0 60 60
                                10 60 40
                                20 60 20
                                30 60 0
                            */
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            var FontEndX = RX + Math.Cos(-EveryDeg * i * Math.PI / 180) * (R - LineLength - 10);
                            var FontEndY = RY + Math.Sin(-EveryDeg * i * Math.PI / 180) * (R - LineLength - 10);
                            g.DrawString(((30 - i) * EveryTemp).ToString(), font, brushText, (float)FontEndX, (float)FontEndY, sf);
                        }
                    }
                }
                
                var PointX = RX + Math.Cos(-(180 - CurrentTemp / EveryTemp * EveryDeg) * Math.PI / 180) * (R - 10);
                var PointY = RY + Math.Sin(-(180 - CurrentTemp / EveryTemp * EveryDeg) * Math.PI / 180) * (R - 10);
                g.DrawLine(Pens.Green, (int)PointX, (int)PointY, (int)RX, (int)RY);
                Point[] pts = new Point[3];
                // 三个角度，0°、120°、240°
                double[] angles = { -(180 - CurrentTemp / EveryTemp * EveryDeg), -(180 - CurrentTemp / EveryTemp * EveryDeg) + 150, -(180 - CurrentTemp / EveryTemp * EveryDeg) + 210 };

                for (int i = 0; i < 3; i++)
                {
                    double rad = angles[i] * Math.PI / 180;
                    int x = (int)PointX + (int)(5 * Math.Cos(rad));
                    int y = (int)PointY + (int)(5 * Math.Sin(rad));
                    pts[i] = new Point(x, y);
                }

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 255, 0, 0)))
                {
                    g.FillPolygon(brush, pts);
                }
            }
        }
    }
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}

```

![1787806358396](assets/1787806358396.png) 