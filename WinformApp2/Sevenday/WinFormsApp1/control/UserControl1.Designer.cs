namespace WinFormsApp1.control
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            input4 = new AntdUI.Input();
            label5 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label1.Location = new Point(245, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 34);
            label1.TabIndex = 0;
            label1.Text = "图书新增";
            // 
            // label2
            // 
            label2.Font = new Font("楷体", 14.25F);
            label2.Location = new Point(120, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 34);
            label2.TabIndex = 0;
            label2.Text = "图书名称";
            // 
            // label3
            // 
            label3.Font = new Font("楷体", 14.25F);
            label3.Location = new Point(120, 155);
            label3.Name = "label3";
            label3.Size = new Size(99, 34);
            label3.TabIndex = 0;
            label3.Text = "图书作者";
            // 
            // label4
            // 
            label4.Font = new Font("楷体", 14.25F);
            label4.Location = new Point(120, 302);
            label4.Name = "label4";
            label4.Size = new Size(99, 34);
            label4.TabIndex = 0;
            label4.Text = "图书简介";
            // 
            // input1
            // 
            input1.Location = new Point(228, 71);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入书名";
            input1.Size = new Size(260, 40);
            input1.TabIndex = 1;
            // 
            // input2
            // 
            input2.Location = new Point(228, 151);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者";
            input2.Size = new Size(260, 44);
            input2.TabIndex = 1;
            // 
            // input3
            // 
            input3.Location = new Point(228, 302);
            input3.Multiline = true;
            input3.Name = "input3";
            input3.PlaceholderText = "请输入简介";
            input3.Size = new Size(260, 74);
            input3.TabIndex = 1;
            // 
            // input4
            // 
            input4.ForeColor = SystemColors.ActiveBorder;
            input4.Location = new Point(228, 223);
            input4.Name = "input4";
            input4.PlaceholderText = "请输入价格";
            input4.Size = new Size(260, 44);
            input4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("楷体", 14.25F);
            label5.Location = new Point(120, 227);
            label5.Name = "label5";
            label5.Size = new Size(99, 34);
            label5.TabIndex = 2;
            label5.Text = "图书价格";
            // 
            // button1
            // 
            button1.Location = new Point(245, 392);
            button1.Name = "button1";
            button1.Size = new Size(177, 45);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.Click += button1_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(input4);
            Controls.Add(label5);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(615, 453);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.Input input4;
        private AntdUI.Label label5;
        private AntdUI.Button button1;
    }
}
