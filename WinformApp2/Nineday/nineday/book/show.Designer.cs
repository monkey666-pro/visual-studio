namespace nineday.book
{
    partial class show
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
            table1 = new AntdUI.Table();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(60, 83);
            table1.Name = "table1";
            table1.Size = new Size(646, 302);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // button1
            // 
            button1.Location = new Point(51, 54);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 1;
            button1.Text = "add'";
            // 
            // show
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(table1);
            Name = "show";
            Text = "show";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Button button1;
    }
}