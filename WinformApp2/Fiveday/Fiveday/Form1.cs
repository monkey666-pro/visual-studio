using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fiveday
{
    
    public partial class Form1 : Form
        
    {
        private List<Dictionary<string, dynamic>> list = new();
        public Form1()
        {
            InitializeComponent();
            list = new()
            {
                new Dictionary<string, dynamic>()
                {
                    ["id"]=1,
                    ["name"]="广东省",
                    ["parentid"]=0
                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=2,
                    ["name"]="深圳市",
                    ["parentid"]=1
                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=3,
                    ["name"]="广州市",
                    ["parentid"]=1

                },
                   new Dictionary<string, dynamic>()
                {
                    ["id"]=4,
                    ["name"]="广西省",
                    ["parentid"]=0

                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=5,
                    ["name"]="柳州市",
                    ["parentid"]=4

                }
            };
            List<Dictionary<string, dynamic>> prolist = list.FindAll(i => i["parentid"]==0);
            var a = prolist.Select(i => i["name"]);
            comboBox1.SelectedIndexChanged += lb2;
            comboBox1.Items.AddRange(a.ToArray()); 
        }
        public void lb2(object sender, EventArgs e)
        {
            //获取列表框的数据，根据获取的省份id匹配parentid，一样就是改省的城市
            string text = comboBox1.SelectedItem.ToString();
            Dictionary<string ,dynamic>newlist= list.Find(i => i["name"] == text);
           List<Dictionary<string, dynamic>>city= list.FindAll(i => i["parentid"] == newlist["id"] );
            var citys = city.Select(i => i["name"]);
            comboBox2.Items.Clear();
            comboBox2.Text = "请选择市";
            comboBox2.Items.AddRange(citys.ToArray());

        }
    }
}
