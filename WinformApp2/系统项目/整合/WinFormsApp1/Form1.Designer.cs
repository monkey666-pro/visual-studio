namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            menuStrip1 = new MenuStrip();
            用户中心ToolStripMenuItem = new ToolStripMenuItem();
            登录ToolStripMenuItem = new ToolStripMenuItem();
            注册ToolStripMenuItem = new ToolStripMenuItem();
            注销ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 25);
            label1.Margin = new Padding(2, 3, 2, 3);
            label1.Name = "label1";
            label1.Size = new Size(764, 71);
            label1.TabIndex = 0;
            label1.Text = "目录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(47, 134);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 74);
            button1.TabIndex = 1;
            button1.Text = "图书管理系统";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 282);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(150, 74);
            button2.TabIndex = 1;
            button2.Text = "车辆租还系统";
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 用户中心ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // 用户中心ToolStripMenuItem
            // 
            用户中心ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 登录ToolStripMenuItem, 注册ToolStripMenuItem, 注销ToolStripMenuItem });
            用户中心ToolStripMenuItem.Name = "用户中心ToolStripMenuItem";
            用户中心ToolStripMenuItem.Size = new Size(68, 21);
            用户中心ToolStripMenuItem.Text = "用户中心";
            // 
            // 登录ToolStripMenuItem
            // 
            登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            登录ToolStripMenuItem.Size = new Size(100, 22);
            登录ToolStripMenuItem.Text = "登录";
            // 
            // 注册ToolStripMenuItem
            // 
            注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            注册ToolStripMenuItem.Size = new Size(100, 22);
            注册ToolStripMenuItem.Text = "注册";
            // 
            // 注销ToolStripMenuItem
            // 
            注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            注销ToolStripMenuItem.Size = new Size(100, 22);
            注销ToolStripMenuItem.Text = "注销";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(764, 513);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 用户中心ToolStripMenuItem;
        private ToolStripMenuItem 登录ToolStripMenuItem;
        private ToolStripMenuItem 注册ToolStripMenuItem;
        private ToolStripMenuItem 注销ToolStripMenuItem;
    }
}
