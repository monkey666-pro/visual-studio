namespace six.a
{
    partial class delbook
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
            button1 = new AntdUI.Button();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BorderWidth = 1F;
            button1.Location = new Point(177, 172);
            button1.Name = "button1";
            button1.Shape = AntdUI.TShape.Round;
            button1.Size = new Size(136, 39);
            button1.TabIndex = 12;
            button1.Text = "删除";
            // 
            // input2
            // 
            input2.Location = new Point(148, 81);
            input2.Name = "input2";
            input2.Size = new Size(338, 57);
            input2.TabIndex = 10;
            input2.Text = "请输入内容";
            // 
            // input1
            // 
            input1.Location = new Point(148, 36);
            input1.Name = "input1";
            input1.Size = new Size(338, 63);
            input1.TabIndex = 11;
            input1.Text = "请输入内容";
            // 
            // label2
            // 
            label2.Location = new Point(108, 87);
            label2.Name = "label2";
            label2.Shadow = 2;
            label2.Size = new Size(145, 47);
            label2.TabIndex = 5;
            label2.Text = "作者";
            // 
            // label5
            // 
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(212, 10);
            label5.Name = "label5";
            label5.Shadow = 2;
            label5.Size = new Size(101, 23);
            label5.TabIndex = 6;
            label5.Text = "图书删除";
            // 
            // label1
            // 
            label1.Location = new Point(108, 45);
            label1.Name = "label1";
            label1.Shadow = 2;
            label1.Size = new Size(145, 47);
            label1.TabIndex = 7;
            label1.Text = "书名";
            // 
            // delbook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "delbook";
            Size = new Size(524, 295);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.Label label5;
        private AntdUI.Label label1;
    }
}
