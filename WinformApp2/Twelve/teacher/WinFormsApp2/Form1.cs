namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 一般容器控件都有 Paint 画图事件
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // 获取画图对象
            Graphics g = e.Graphics;
            // 设置抗锯齿
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 创建画笔 
            using (SolidBrush brushGreen = new SolidBrush(Color.Green))
            using (SolidBrush brushBlack = new SolidBrush(Color.Black))
            using (SolidBrush brushColor = new SolidBrush(Color.FromArgb(128, 100, 255, 100)))
            using (Pen penRed = new Pen(Color.Red, 4))
            using (Pen penO = new Pen(Color.Orange, 4))
            {
                // 画矩形: 画笔, 起始坐标x,y, 宽, 高
                g.DrawRectangle(penRed, 10, 10, 200, 100);

                // 填充矩形
                g.FillRectangle(brushGreen, 220, 10, 200, 200);
                g.FillRectangle(brushColor, 440, 10, 200, 200);

                // 画圆心: 圆对应矩形的起始坐标x,y
                g.DrawEllipse(penRed, 10, 220, 200, 200);

                // 实心圆
                g.FillEllipse(brushColor, 230, 220, 200, 200);

                // 椭圆
                //g.DrawEllipse(penO, 10, 10, 200, 100);

                // 画线: 
                g.DrawLine(penO,500,300,700,300);

                // 画文字
                Font f = new Font("微软雅黑", 18);
                //g.DrawString("GDI+f测试文字", f, brushBlack, 500, 300);
                StringFormat Sf = new StringFormat();
                Sf.Alignment = StringAlignment.Center;
                Sf.LineAlignment = StringAlignment.Center;
                g.DrawString("GDI+f测试文字", f, brushBlack, 500, 300,Sf);

                // 画多边形
                //Point[] points =
                //{
                //    new Point(750,10),
                //    new Point(950,10),
                //    new Point(900,210),
                //    new Point(700,210),
                //};

                //g.DrawPolygon(penRed,points);
                //g.FillPolygon(brushColor, points);

                Point[] points =
                {
                    new Point(750,10),
                    new Point(950,10),
                    new Point(900,210)                    
                };
                g.DrawPolygon(penRed, points);
                Point[] points2 =
               {
                    new Point(750,10),
                    new Point(900,210),
                     new Point(700,210),
                };
                g.FillPolygon(brushColor,points2);
            }

        }
    }
}
