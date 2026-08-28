namespace WinFormsApp1
{
    partial class LunBoTu
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
            box = new Panel();
            label1 = new Label();
            labelTime = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // box
            // 
            box.BackColor = Color.Black;
            box.Location = new Point(100, 82);
            box.Name = "box";
            box.Size = new Size(96, 86);
            box.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 54);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "按键按下时长ms: ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(757, 54);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(0, 20);
            labelTime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // LunBoTu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(label2);
            Controls.Add(labelTime);
            Controls.Add(label1);
            Controls.Add(box);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LunBoTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LunBoTu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel box;
        private Label label1;
        private Label labelTime;
        private Label label2;
    }
}