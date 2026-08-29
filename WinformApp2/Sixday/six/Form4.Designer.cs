namespace six
{
    partial class Form4
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
            userControl11 = new six.a.addbook();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(164, 41);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(477, 271);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            // 
            // label1
            // 
            label1.Location = new Point(67, 115);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "a";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(userControl11);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private a.addbook userControl11;
        private AntdUI.Label label1;
    }
}