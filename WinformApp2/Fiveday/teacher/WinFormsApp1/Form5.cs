namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        private Point P;
        public Form5()
        {
            InitializeComponent();
            // 给按钮绑定鼠标 按下 移动 松开
            button1.MouseDown += Button1_MouseDown;
            
            button1.MouseUp += Button1_MouseUp; ;

            richTextBox1.GotFocus += RichTextBox1_GotFocus; // 为了关闭窗体
        }

        private void RichTextBox1_GotFocus(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            // 鼠标松开 则解绑鼠标移动事件
            button1.MouseMove -= Button1_MouseMove;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            // P 是鼠标按下时候的坐标(固定的), 鼠标移动时候的相对坐标
            // 将鼠标相对于 按钮的坐标转为  鼠标相对于屏幕的坐标
            Point m_s = button1.PointToScreen(e.Location);

            // 鼠标相对于屏幕的坐标 减去  鼠标相对于按钮的坐标 得到 按钮相对于屏幕坐标
            m_s.Offset(-P.X, -P.Y);

            // 将按钮相对于屏幕的坐标 转为 按钮相对于窗体的坐标
            Point b_f = this.PointToClient(m_s);

            // 限定极限位置
            if (b_f.X <= 0) b_f.X = 0;
            if (b_f.Y <= 0) b_f.Y = 0;
            int MaxY = this.Height - button1.Height;
            int MaxX = this.Width - button1.Width;
            if (b_f.X >= MaxX) b_f.X = MaxX;
            if (b_f.Y >= MaxY) b_f.Y = MaxY;

            // 按钮相对于窗体的坐标 赋值给 按钮的Location坐标
            button1.Location = b_f;


        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            // 鼠标按下绑定 按钮的鼠标移动事件
            button1.MouseMove += Button1_MouseMove;

            // 鼠标按下先获取  鼠标相对于 按钮的位置
            P = e.Location;
        }
    }
}





//namespace WinFormsApp1
//{
//    public partial class Form5 : Form
//    {
//        private Point P;
//        private bool flag = false;
//        public Form5()
//        {
//            InitializeComponent();
//            // 给按钮绑定鼠标 按下 移动 松开
//            button1.MouseDown += Button1_MouseDown;
//            button1.MouseMove += Button1_MouseMove;
//            button1.MouseUp += Button1_MouseUp; ;

//            richTextBox1.GotFocus += RichTextBox1_GotFocus;
//        }

//        private void RichTextBox1_GotFocus(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void Button1_MouseUp(object sender, MouseEventArgs e)
//        {
//            flag = false;
//        }

//        private void Button1_MouseMove(object sender, MouseEventArgs e)
//        {

//            if (!flag)
//            {
//                return;
//            }
//            // P 是鼠标按下时候的坐标(固定的), 鼠标移动时候的相对坐标
//            // 将鼠标相对于 按钮的坐标转为  鼠标相对于屏幕的坐标
//            Point m_s = button1.PointToScreen(e.Location);

//            // 鼠标相对于屏幕的坐标 减去  鼠标相对于按钮的坐标 得到 按钮相对于屏幕坐标
//            m_s.Offset(-P.X, -P.Y);

//            // 将按钮相对于屏幕的坐标 转为 按钮相对于窗体的坐标
//            Point b_f = this.PointToClient(m_s);

//            // 限定极限位置
//            if (b_f.X <= 0) b_f.X = 0;
//            if (b_f.Y <= 0) b_f.Y = 0;
//            int MaxY = this.Height - button1.Height;
//            int MaxX = this.Width - button1.Width;
//            if (b_f.X >= MaxX) b_f.X = MaxX;
//            if (b_f.Y >= MaxY) b_f.Y = MaxY;

//            // 按钮相对于窗体的坐标 赋值给 按钮的Location坐标
//            button1.Location = b_f;


//        }

//        private void Button1_MouseDown(object sender, MouseEventArgs e)
//        {
//            // 鼠标按下打开 开关
//            flag = true;
//            // 鼠标按下先获取  鼠标相对于 按钮的位置
//            P = e.Location;






//            //// e.Location.X ====> e.X
//            //// 鼠标相对于 按钮
//            //MessageBox.Show(e.X.ToString());

//            //// 将鼠标在控件上的位置 转为 鼠标相对于屏幕的位置
//            //Point m_s = button1.PointToScreen(e.Location);  // Point 类型 数据 {X,Y}


//            //// 鼠标相对于 屏幕位置
//            //MessageBox.Show(m_s.X.ToString());

//            //// 从原坐标上偏移
//            ////Point坐标.Offset(+1, -1)
//            //m_s.Offset(-e.X, -e.Y); // 此时m_s 是按钮相对于 屏幕的位置
//            ////m_s.X = m_s.X - e.X;
//            ////m_s.Y = m_s.Y - e.Y;

//            //MessageBox.Show(m_s.X.ToString());

//            //// 将Point坐标换算成某个父容器内部的坐标
//            //Point b_f = this.PointToClient(m_s); // b_f就是按钮相对于form窗体的位置
//            //MessageBox.Show(b_f.X.ToString());
//        }
//    }
//}
