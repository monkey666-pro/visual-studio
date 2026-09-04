namespace WinFormsApp1.Book
{
    partial class signup
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
            button1 = new AntdUI.Button();
            input2 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            checkbox1 = new AntdUI.Checkbox();
            checkbox2 = new AntdUI.Checkbox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 346);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(210, 67);
            button1.TabIndex = 10;
            button1.Text = "注册";
            // 
            // input2
            // 
            input2.Location = new Point(299, 162);
            input2.Margin = new Padding(2, 3, 2, 3);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(275, 63);
            input2.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(180, 174);
            label3.Margin = new Padding(2, 3, 2, 3);
            label3.Name = "label3";
            label3.Size = new Size(114, 38);
            label3.TabIndex = 6;
            label3.Text = "密码: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(299, 77);
            input1.Margin = new Padding(2, 3, 2, 3);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(275, 63);
            input1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Location = new Point(180, 89);
            label2.Margin = new Padding(2, 3, 2, 3);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 7;
            label2.Text = "用户名: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 3, 2, 3);
            label1.Name = "label1";
            label1.Size = new Size(800, 71);
            label1.TabIndex = 5;
            label1.Text = "注册";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(180, 267);
            label4.Margin = new Padding(2, 3, 2, 3);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 6;
            label4.Text = "确认密码";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            input3.Location = new Point(299, 255);
            input3.Margin = new Padding(2, 3, 2, 3);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入密码";
            input3.Size = new Size(275, 63);
            input3.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(342, 141);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 11;
            label5.Text = "用户名长度为3-10";
            // 
            // label6
            // 
            label6.Location = new Point(342, 226);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 11;
            label6.Text = "密码长度为8-15";
            // 
            // label7
            // 
            label7.Location = new Point(579, 89);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 11;
            label7.Text = "用户名长度为3-10";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.Location = new Point(579, 189);
            label8.Name = "label8";
            label8.Size = new Size(130, 23);
            label8.TabIndex = 11;
            label8.Text = "用户名长度为3-10";
            label8.Visible = false;
            // 
            // checkbox1
            // 
            checkbox1.Location = new Point(282, 324);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(104, 23);
            checkbox1.TabIndex = 12;
            checkbox1.Text = "男";
            checkbox1.CheckedChanged += checkbox1_CheckedChanged;
            // 
            // checkbox2
            // 
            checkbox2.Location = new Point(431, 324);
            checkbox2.Name = "checkbox2";
            checkbox2.Size = new Size(104, 23);
            checkbox2.TabIndex = 12;
            checkbox2.Text = "女";
            checkbox2.CheckedChanged += checkbox2_CheckedChanged;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkbox2);
            Controls.Add(checkbox1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(input3);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "Form1";
            Load += signup_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Input input2;
        private AntdUI.Label label3;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label4;
        private AntdUI.Input input3;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Checkbox checkbox2;
    }
}