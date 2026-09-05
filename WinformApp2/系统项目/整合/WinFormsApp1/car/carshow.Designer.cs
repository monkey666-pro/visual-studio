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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carshow));
            table1 = new AntdUI.Table();
            button1 = new AntdUI.Button();
            label1 = new AntdUI.Label();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button4 = new AntdUI.Button();
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
            button1.BackColor = Color.Brown;
            button1.Font = new Font("楷体", 10.5F, FontStyle.Bold);
            button1.Location = new Point(44, 394);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 1;
            button1.Text = "新增车辆";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(311, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 47);
            label1.TabIndex = 2;
            label1.Text = "车辆界面";
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("楷体", 10.5F, FontStyle.Bold);
            button2.Location = new Point(220, 394);
            button2.Name = "button2";
            button2.Size = new Size(170, 44);
            button2.TabIndex = 1;
            button2.Text = "客户界面";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("楷体", 10.5F, FontStyle.Bold);
            button3.Location = new Point(396, 394);
            button3.Name = "button3";
            button3.Size = new Size(170, 44);
            button3.TabIndex = 1;
            button3.Text = "租车";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("楷体", 10.5F, FontStyle.Bold);
            button4.Location = new Point(572, 394);
            button4.Name = "button4";
            button4.Size = new Size(170, 44);
            button4.TabIndex = 1;
            button4.Text = "查看记录";
            button4.Click += button1_Click;
            // 
            // carshow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
    }
}