namespace WinFormsApp1.book
{
    partial class bookadd
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
            userControl11 = new WinFormsApp1.control.UserControl1();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(57, 12);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(615, 453);
            userControl11.TabIndex = 0;
            // 
            // bookadd
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControl11);
            Name = "bookadd";
            Text = "bookadd";
            ResumeLayout(false);
        }

        #endregion

        private control.UserControl1 userControl11;
    }
}