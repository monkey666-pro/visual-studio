namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Panel panel1;
        private Button btn1;
        private Button btn2;
        private Label lab1;
        private Label lab2;
        private TextBox tb1;

        public void Opt()
        {
            // 实例化  控件实例   控件类型 就是控件名称
            panel1 = new Panel();
            panel1.Location = new Point(50, 50);
            panel1.Size = new Size(300, 300);
            panel1.Name = "panel1";

            // From1窗体的Controls.Add方法 将创建的panel1添加到了 窗体中
            this.Controls.Add(panel1);
            // 创建btn按钮 
            btn2 = new Button();
            btn2.Location = new Point(400, 0);
            btn2.Size = new Size(100, 50);
            btn2.Name = "btn2";
            btn2.Text = "btn2按钮  ";
            this.Controls.Add(btn2);


            // 创建btn按钮 
            btn1 = new Button();
            btn1.Location = new Point(0, 0);
            btn1.Size = new Size(100, 50);
            btn1.Name = "btn1";
            btn1.Text = "btn确定  ";

            // 创建label
            lab1 = new Label()
            {
                Location = new Point(0, 60),
                Size = new Size(100, 50),
                Name = "lab1",
                Text = "lab内容  "
            };

            // 创建输入框
            tb1 = new TextBox();
            tb1.Location = new Point(120, 0);
            tb1.Name = "tb1";
            tb1.Text = "tb内容  ";

            lab2 = new Label()
            {
                Location = new Point(120, 60),
                Size = new Size(100, 50),
                Name = "lab2",
                Text = "lab2内容  "
            };


            // 将创建的btn按钮添加到页面中
            // panel1.Controls.Add(btn1);

            // 所有控件的继承链上都会有 Control 
            // 将创建的控件 批量添加到panel1
            Control[] cs = [btn1, lab1, tb1, lab2];
            panel1.Controls.AddRange(cs);

            #region Controls 方法
            // Controls 中的其他方法
            // Remove ：从容器中删除指定的控件
            //panel1.Controls.Remove(lab1);

            // RemoveAt ：从容器中删除指定索引的控件
            //panel1.Controls.RemoveAt(2);

            // Clear 清空
            //panel1.Controls.Clear();

            ////SetChildIndex：修改控件的下标
            //panel1.Controls.SetChildIndex(btn1, 2);

            ////GetChildIndex：获取控件的下标
            //btn1.Text += panel1.Controls.GetChildIndex(btn1);
            //lab1.Text += panel1.Controls.GetChildIndex(lab1);
            //tb1.Text += panel1.Controls.GetChildIndex(tb1);
            //lab2.Text += panel1.Controls.GetChildIndex(lab2);

            // Contains 判断控件是否在容器中
            //btn1.Text += panel1.Controls.Contains(btn1);
            //btn2.Text += panel1.Controls.Contains(btn2);

            // IndexOf 获取控件在 容器中的索引
            //btn1.Text += panel1.Controls.IndexOf(btn1);
            //btn2.Text += panel1.Controls.IndexOf(btn2);


            // Controls的属性
            //btn1.Text += panel1.Controls.Count;
            //btn1.Text += panel1.Controls.IndexOf(panel1.Controls[2]);
            //btn1.Text += panel1.Controls.IndexOf(panel1.Controls["lab2"]);
            #endregion

            // 事件: 3要素,事件源,事件类型,事件处理程序
            btn2.Click += Btn2_Click;

        }

        // 作为事件处理程序(方法)  必须要有两个参数
        private void Btn2_Click(object Sender, EventArgs e)
        {
            // EventArgs e: 表示本次事件的 事件对象
            // 事件对象:  本次事件触发时候 系统给封装的一个包含所有事件相关信息的对象

            // object Sender: 表示本次事件的事件源(触发事件的控件)
            // 注意: 此时拿到的 (控件) 是 object类型,不具备控件的属性
            // 所以需要将 事件源的类型转为 对应控件的类型
            // 强制转换: (类型)值  ===转失败报错====>  (Button)Sender    
            // 安全转换:  值 as 类型  ====转失败为空====> Sender as Button


            //Button btn = (Button)Sender;
            Button btn = Sender as Button;
            btn.Text = "哈哈哈哈";

        }

        public Form1()
        {
            InitializeComponent();
            Opt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "6666";
            ((Button)sender).BackColor = Color.Red;
        }
    }
}
