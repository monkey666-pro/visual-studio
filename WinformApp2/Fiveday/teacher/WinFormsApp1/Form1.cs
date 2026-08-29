using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Dictionary<string, dynamic>> data = new();
        public Form1()
        {
            InitializeComponent();
            // 初始化数据
            data = new() {
                new Dictionary<string, dynamic>() {
                    ["id"] = 1,
                    ["name"] = "广东省",
                    ["parentId"] = 0
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 2,
                    ["name"] = "广州市",
                    ["parentId"] = 1
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 3,
                    ["name"] = "深圳市",
                    ["parentId"] = 1
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 4,
                    ["name"] = "佛山市",
                    ["parentId"] = 1
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 5,
                    ["name"] = "湖南省",
                    ["parentId"] = 0
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 6,
                    ["name"] = "长沙市",
                    ["parentId"] = 5
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 7,
                    ["name"] = "湘潭市",
                    ["parentId"] = 5
                },
                new Dictionary<string, dynamic>() {
                    ["id"] = 8,
                    ["name"] = "永州市",
                    ["parentId"] = 5
                },
            };
            // 初始化一级下拉框
            List<Dictionary<string, dynamic>> proList = data.FindAll(item => item["parentId"] == 0);
            // 获取所有的名称 组成数组
            dynamic[] proNameArr = proList.Select(item => item["name"]).ToArray();
            ProvinceCb.Items.AddRange(proNameArr);
            // 事件
            ProvinceCb.SelectedIndexChanged += proChange;


        }

        private void proChange(object sender,EventArgs e)
        {
            // 获取选中项的内容
            string pro = (sender as ComboBox).SelectedItem.ToString();
            // 先获取省份字典的 id
            int ProId = data.Find(item => item["name"] == pro)["id"];
            // 城市和省份的关系, 城市字典的parentId == 城市id
            List<Dictionary<string, dynamic>> cityList = data.FindAll(item => item["parentId"] == ProId);
            // 获取所有的名称 组成数组
            dynamic[] cityNameArr = cityList.ConvertAll(item => item["name"]).ToArray();
            CityCb.Text = "请选择城市";
            // 需要先清空CityCb.Items
            CityCb.Items.Clear();
            CityCb.Items.AddRange(cityNameArr);
        }
    }
}
/*
 二级联动:
    - 模拟二级联动数据: 
        - 字典: {id=唯一,name=省份/城市,parentId=0/对应省份id}
        - List<字典> 组成所有数据
    - 界面中一级下拉框始化数据
        - 获取List中的所有省份添加到 ProvinceCb的子项中
    - 实现二级数据展示
        - 给一级下拉框通过 选中项变化 事件触发二级数据的展示
            + 事件方法中: 根据选中项的省份 求 List中查找对应的城市
            + 将对象的城市 展示到 二级下拉框
*/