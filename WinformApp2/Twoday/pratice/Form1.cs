namespace pratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            into();

        }
        public void into()//手动事件
        {
            textBox1.Leave += tb;
            textBox1.TextChanged += tb1;
        }

        private void tb(object sender, EventArgs e)
        {
            //先用字符串收集文本内容如果内容为空则lable显示内容(无法实时显示)
            //如果和textchaged搭配ture的条件要删除，因为显示了需要再次离开文本框才更新状态
            string arr = textBox1.Text;
            if (string.IsNullOrEmpty(arr))
            {
                textBox1.Focus();//为空的话光标就固定
                label1.Visible = true;
            }
        }
        public void tb1(object sender, EventArgs e)//实时跟踪输入框的内容
        {
            //同样有字符串存文本如何判断是否为空
            string arr = textBox1.Text;
            if (!string.IsNullOrEmpty(arr))
            {
                //如果不为空就不显示
                label1.Visible = false;//逻辑易错点：我们要的作用只是输入字符就不显示lable了，如果条件为空显示的话，一开始离开对话框lable就不显示
                //反过来：如果我们实现了对话框状态的实时更新，但是一开始的时候没有移到对话框lable就不显示，这时我们就需要上面leave方法来判定如果一开始没有移到对话框就显示lable
            }
        }
    }
}
