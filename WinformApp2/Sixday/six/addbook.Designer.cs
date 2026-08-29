namespace six
{
    partial class addbook
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
            addbook1 = new six.a.addbook();
            SuspendLayout();
            // 
            // addbook1
            // 
            addbook1.Location = new Point(120, 12);
            addbook1.Name = "addbook1";
            addbook1.Size = new Size(559, 324);
            addbook1.TabIndex = 0;
            // 
            // addbook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addbook1);
            Name = "addbook";
            Text = "addbook";
            ResumeLayout(false);
        }

        #endregion

        private a.addbook addbook1;
    }
}