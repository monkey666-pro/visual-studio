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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            heightLab = new Label();
            widthLab = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(616, 72);
            button1.Name = "button1";
            button1.Size = new Size(213, 83);
            button1.TabIndex = 0;
            button1.Text = "打开窗体1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(616, 256);
            button2.Name = "button2";
            button2.Size = new Size(213, 83);
            button2.TabIndex = 0;
            button2.Text = "打开窗体2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 112);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "宽: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 162);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "高: ";
            // 
            // heightLab
            // 
            heightLab.AutoSize = true;
            heightLab.Location = new Point(154, 162);
            heightLab.Name = "heightLab";
            heightLab.Size = new Size(0, 20);
            heightLab.TabIndex = 1;
            // 
            // widthLab
            // 
            widthLab.AutoSize = true;
            widthLab.Location = new Point(154, 112);
            widthLab.Name = "widthLab";
            widthLab.Size = new Size(0, 20);
            widthLab.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 549);
            Controls.Add(widthLab);
            Controls.Add(heightLab);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label heightLab;
        private Label widthLab;
    }
}
