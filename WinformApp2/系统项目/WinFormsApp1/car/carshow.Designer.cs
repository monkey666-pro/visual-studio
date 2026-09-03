namespace WinFormsApp1.car
{
    partial class carshow
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
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(59, 65);
            table1.Name = "table1";
            table1.Size = new Size(663, 320);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // button1
            // 
            button1.Location = new Point(293, 391);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 1;
            button1.Text = "新增车辆";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(311, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 47);
            label1.TabIndex = 2;
            label1.Text = "车辆界面";
            // 
            // carshow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(table1);
            Name = "carshow";
            Text = "carshow";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Button button1;
        private AntdUI.Label label1;
    }
}