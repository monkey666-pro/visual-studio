using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics; // 画图对象
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 抗锯齿
            int Radius = 100;
            int cx = 100;
            int cy = 100;

            //Point[] points = new Point[3];
            //// 弧度 = 角度*π/180
            //double[] angles = { 30, 150, 270 };

            //// 遍历角度 将角度转为===> 对应的坐标点
            //for (int i = 0; i < angles.Length; i++)
            //{

            //    var px = Math.Cos(angles[i] * Math.PI / 180) * Radius + cx;
            //    var py = Math.Sin(angles[i] * Math.PI / 180) * Radius + cy;
            //    points[i] = new Point((int)px, (int)py);
            //}

            //using (Pen penRed = new Pen(Color.Red,2))
            //{
            //    // 画多边形===>三个点
            //    g.DrawPolygon(penRed, points);

            //    //g.DrawEllipse(penRed, 0, 0, 200, 200);
            //}

            //using (Pen penRed = new Pen(Color.Red, 2))
            //using (var brushRed = new SolidBrush(Color.Red))
            //{
            //    // 画笔, 圆矩形起始点,宽高,开始角度,走过的角度
            //    //g.DrawArc(penRed, 10, 10, 100, 100, 0, 90);
            //    //g.DrawArc(penRed, 10, 10, 100, 100, 0, 360);
            //    var Rg = new Rectangle(10, 10, 100, 100);
            //    //g.DrawArc(penRed, Rg, 270, 90); 


            //}

        }
    }
}
