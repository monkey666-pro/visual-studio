namespace six
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new AntdUI.Button();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 54);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "名字";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 99);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 0;
            label2.Text = "年龄";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(394, 11);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(405, 384);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.BorderWidth = 2F;
            button2.Location = new Point(172, 235);
            button2.Name = "button2";
            button2.Shape = AntdUI.TShape.Circle;
            button2.Size = new Size(132, 59);
            button2.TabIndex = 5;
            button2.Text = "获取数量";
            button2.ToggleText = "fff";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(238, 159);
            button1.Name = "button1";
            button1.Size = new Size(83, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button2;
        private AntdUI.Button button1;
    }
}