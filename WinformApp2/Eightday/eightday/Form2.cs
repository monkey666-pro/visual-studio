using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eightday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
            this.Shown += show;//shown：窗体显示完成的界面
        }
        public void show(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";//播放文件的地址
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = "";
            //axWindowsMediaPlayer1.uiMode=""
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();//.后面跟播放的节奏
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
