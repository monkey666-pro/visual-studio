using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fiveday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            all.CheckStateChanged += cc;//复选框选中改变事件，因为all还要显示半选所以要State，不过仅供显示
            foreach (Control i in panel1.Controls)
            {
                (i as CheckBox).CheckedChanged += cc1;// panel要全勾或不勾即可
            }
           
        }
        public void cc(object sender, EventArgs e)
        {
            //获取当前全选按钮的状态,(注意：点击全选只能有二种状态，半选要通过代码才显示)
            //MessageBox.Show(all.Checked.ToString());
           //注意：判断all受否为check而不是indeterminate
            if (all.CheckState != CheckState.Indeterminate)//当不为indeterminate时才执行
            {
                if (all.CheckState == CheckState.Checked)
                {
                    foreach (Control i in panel1.Controls)
                    {
                        ((CheckBox)i).Checked = true;
                    }
                }
                else
                {
                    foreach (Control i in panel1.Controls)
                    {
                        ((CheckBox)i).Checked = false;
                    }
                }
            }
        }
        public void cc1(object sender, EventArgs e)
        {
            //如果panel中全部点完全选就勾，如果至少 一个就显示半选，都不选全选就无(注意详细属性)
            List<CheckBox> a = panel1.Controls.OfType<CheckBox>().ToList();//挑选panel中的checkbox
            if (a.All(i => i.Checked))
            {
                all.CheckState = CheckState.Checked;
            }
            else
            {
                if (a.Any(i => i.Checked))
                {
                    all.CheckState = CheckState.Indeterminate;

                }
                else all.CheckState = CheckState.Unchecked;
            }
          


        }


    }
}
