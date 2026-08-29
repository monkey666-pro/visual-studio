using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // 复选框- 选中改变事件
            AllCbox.CheckStateChanged += AllChanged;

            // 给所有的 单个复选框 绑定事件 CheckedChanged
            foreach (Control ItemBox in ChildPan.Controls) (ItemBox as CheckBox).CheckedChanged += ItemChanged;

        }

        private void ItemChanged(object sender, EventArgs e)
        {
            //  OfType<> 过滤方法得到一个只有Control类型的集合
            List<Control> childList = ChildPan.Controls.OfType<Control>().ToList();

            // 判断是否所有都选中  list中的 TrueForAll
            bool isAll = childList.All(item => (item as CheckBox).Checked);
            // 判断是否有选中 (至少一个选中) Some
            bool isAny = childList.Any(item => (item as CheckBox).Checked);

            // 给AllCbox 设置的状态有三种
            if (isAll)
            {
                AllCbox.CheckState = CheckState.Checked;
            }
            else
            {
                //if (isAny)
                //{
                //    AllCbox.CheckState = CheckState.Indeterminate;
                //}
                //else
                //{
                //    AllCbox.CheckState = CheckState.Unchecked;
                //}
                AllCbox.CheckState = isAny ? CheckState.Indeterminate : CheckState.Unchecked;
            }
        }

        private void AllChanged(object sender, EventArgs e)
        {

            // 获取当前全选按钮的状态
            //MessageBox.Show(AllCbox.Checked.ToString());
            bool isCheck = AllCbox.CheckState == CheckState.Checked ? true : false;
            if (AllCbox.CheckState != CheckState.Indeterminate)
            { // 如果半选则 不改其他内容
                // 遍历 
                foreach (Control ItemBox in ChildPan.Controls)
                {
                    (ItemBox as CheckBox).Checked = isCheck;
                }
            }

        }
    }
}
