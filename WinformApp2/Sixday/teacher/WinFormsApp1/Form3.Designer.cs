namespace WinFormsApp1
{
    partial class Form3
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
            ucText1 = new WinFormsApp1.myControl.UCText();
            ucText2 = new WinFormsApp1.myControl.UCText();
            SuspendLayout();
            // 
            // ucText1
            // 
            ucText1.Location = new Point(23, 29);
            ucText1.Name = "ucText1";
            ucText1.Size = new Size(416, 231);
            ucText1.TabIndex = 0;
            // 
            // ucText2
            // 
            ucText2.Location = new Point(485, 29);
            ucText2.Name = "ucText2";
            ucText2.Size = new Size(416, 231);
            ucText2.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 662);
            Controls.Add(ucText2);
            Controls.Add(ucText1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private myControl.UCText ucText1;
        private myControl.UCText ucText2;
    }
}