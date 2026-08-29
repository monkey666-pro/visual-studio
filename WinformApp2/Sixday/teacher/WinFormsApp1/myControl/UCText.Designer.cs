namespace WinFormsApp1.myControl
{
    partial class UCText
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
            label1 = new Label();
            BookLab = new Label();
            label2 = new Label();
            authoLab = new Label();
            label4 = new Label();
            IntroLab = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "书名: ";
            // 
            // BookLab
            // 
            BookLab.AutoSize = true;
            BookLab.Location = new Point(92, 12);
            BookLab.Name = "BookLab";
            BookLab.Size = new Size(39, 20);
            BookLab.TabIndex = 0;
            BookLab.Text = "三国";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "作者:";
            // 
            // authoLab
            // 
            authoLab.AutoSize = true;
            authoLab.Location = new Point(92, 68);
            authoLab.Name = "authoLab";
            authoLab.Size = new Size(54, 20);
            authoLab.TabIndex = 1;
            authoLab.Text = "罗贯中";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 119);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 1;
            label4.Text = "简介: ";
            // 
            // IntroLab
            // 
            IntroLab.AutoSize = true;
            IntroLab.Location = new Point(92, 119);
            IntroLab.Name = "IntroLab";
            IntroLab.Size = new Size(160, 20);
            IntroLab.TabIndex = 1;
            IntroLab.Text = "东汉末年分三国....曹操";
            // 
            // button1
            // 
            button1.Location = new Point(207, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UCText
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(IntroLab);
            Controls.Add(label4);
            Controls.Add(authoLab);
            Controls.Add(label2);
            Controls.Add(BookLab);
            Controls.Add(label1);
            Name = "UCText";
            Size = new Size(333, 185);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label BookLab;
        private Label label2;
        private Label authoLab;
        private Label label4;
        private Label IntroLab;
        private Button button1;

    }
}
