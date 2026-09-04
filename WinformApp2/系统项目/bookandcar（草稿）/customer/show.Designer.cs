namespace WinFormsApp1.customer
{
    partial class show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            table1 = new AntdUI.Table();
            menuStrip1 = new MenuStrip();
            用户中心ToolStripMenuItem = new ToolStripMenuItem();
            用户登录ToolStripMenuItem = new ToolStripMenuItem();
            用户注册ToolStripMenuItem = new ToolStripMenuItem();
            注销ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(102, 94);
            table1.Name = "table1";
            table1.Size = new Size(574, 332);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 用户中心ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 用户中心ToolStripMenuItem
            // 
            用户中心ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 用户登录ToolStripMenuItem, 用户注册ToolStripMenuItem, 注销ToolStripMenuItem });
            用户中心ToolStripMenuItem.Name = "用户中心ToolStripMenuItem";
            用户中心ToolStripMenuItem.Size = new Size(68, 21);
            用户中心ToolStripMenuItem.Text = "用户中心";
            // 
            // 用户登录ToolStripMenuItem
            // 
            用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            用户登录ToolStripMenuItem.Size = new Size(180, 22);
            用户登录ToolStripMenuItem.Text = "用户登录";
            // 
            // 用户注册ToolStripMenuItem
            // 
            用户注册ToolStripMenuItem.Name = "用户注册ToolStripMenuItem";
            用户注册ToolStripMenuItem.Size = new Size(180, 22);
            用户注册ToolStripMenuItem.Text = "用户注册";
            // 
            // 注销ToolStripMenuItem
            // 
            注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            注销ToolStripMenuItem.Size = new Size(180, 22);
            注销ToolStripMenuItem.Text = "注销";
            // 
            // show
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(table1);
            MainMenuStrip = menuStrip1;
            Name = "show";
            Text = "show";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Table table1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 用户中心ToolStripMenuItem;
        private ToolStripMenuItem 用户登录ToolStripMenuItem;
        private ToolStripMenuItem 用户注册ToolStripMenuItem;
        private ToolStripMenuItem 注销ToolStripMenuItem;
    }
}