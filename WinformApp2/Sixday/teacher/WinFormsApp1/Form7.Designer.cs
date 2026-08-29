namespace WinFormsApp1
{
    partial class Form7
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
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 49);
            button1.Name = "button1";
            button1.Size = new Size(161, 74);
            button1.TabIndex = 0;
            button1.Text = "新增图书";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 148);
            button2.Name = "button2";
            button2.Size = new Size(161, 74);
            button2.TabIndex = 0;
            button2.Text = "编辑图书";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(39, 268);
            button3.Name = "button3";
            button3.Size = new Size(161, 74);
            button3.TabIndex = 0;
            button3.Text = "图书展示";
            button3.Click += button3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
    }
}