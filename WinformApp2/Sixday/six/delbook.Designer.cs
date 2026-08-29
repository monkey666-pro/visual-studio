namespace six
{
    partial class delbook
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
            delbook1 = new six.a.delbook();
            SuspendLayout();
            // 
            // delbook1
            // 
            delbook1.Location = new Point(95, 12);
            delbook1.Name = "delbook1";
            delbook1.Size = new Size(524, 295);
            delbook1.TabIndex = 0;
            // 
            // delbook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delbook1);
            Name = "delbook";
            Text = "delbook";
            ResumeLayout(false);
        }

        #endregion

        private a.delbook delbook1;
    }
}