using System.Drawing.Drawing2D;

namespace twelve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
        }
        public int count=60;
        public int leng=10;
        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush text=new SolidBrush(Color.Black))
            using (Font font = new Font("楷体", 12))
            {
                g.DrawString("哈哈", font, text, 300, 300);
            }
            using (SolidBrush bi = new SolidBrush(Color.Red))
            using (Pen p = new Pen(Color.Green, 2))
            {
                g.DrawRectangle(p, 10, 10, 220, 100);
                g.FillRectangle(bi, 10, 10, 220, 100);
                g.DrawLine(p, 200, 200, 250, 200);
                g.DrawEllipse(p, 10, 110, 100, 100);//在矩形里花园
                g.FillEllipse(bi, 10, 110, 100, 100);
            }
            Point[] points =
               {
                    new Point(200,10),
                    new Point(250,20),
                    new Point(300,30),
                    new Point(320,40)

               };
            using (Pen p = new Pen(Color.DarkMagenta, 2))
            {
                g.DrawPolygon(p, points);
            }
            int r = 100;
            int startx = 350;
            int statry = 350;
            Point[] pts = new Point[3];
            double[] angles = { 30, 150, 270 };
            for (int i = 0; i < 3;i++)
            {
                double rad = angles[i] * Math.PI /180;
                int x =startx +(int) (r * Math.Cos(rad));
                int y = statry + (int)(r * Math.Sin(rad));
                pts[i] = new Point(x, y);
            }
            using (Brush bubu=new SolidBrush(Color.Red))
            using (SolidBrush s = new SolidBrush(Color.Red))
            {
                g.FillPolygon(bubu, pts);
            }
            using (Pen p= new Pen(Color.Black, 2))
            {
                g.DrawArc(p, startx - r, statry - r, 2 * r, 2 * r, 0, 360);
                var tem = leng;
                for (int i = 0; i < count; i++)
                {
                    var x = Math.Cos((360 / count) * i * Math.PI / 180) * r + startx;
                    var y = Math.Sin((360 / count) * i * Math.PI / 180) * r + statry;
                    var endX = Math.Cos((360 / count) * i * Math.PI / 180) * (r - leng/2) + startx;
                    var endY = Math.Sin((360 / count) * i * Math.PI / 180) * (r - leng/2) + statry;
                    g.DrawLine(p, (int)x, (int)y, (int)endX, (int)endY);
                }
            }
        }
    }
}
