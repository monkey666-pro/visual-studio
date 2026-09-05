namespace WinFormsApp1.customer
{
    partial class customershow
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
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(62, 73);
            table1.Name = "table1";
            table1.Size = new Size(652, 333);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("楷体", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(311, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 55);
            label1.TabIndex = 1;
            label1.Text = "客户界面";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(289, 384);
            button1.Name = "button1";
            button1.Size = new Size(181, 45);
            button1.TabIndex = 2;
            button1.Text = "客户注册";
            // 
            // customershow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(table1);
            Name = "customershow";
            Text = "show";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Label label1;
        private AntdUI.Button button1;
    }
}