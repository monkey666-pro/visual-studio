namespace WinFormsApp1.customer
{
    partial class customeredit
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
            input3 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            checkbox2 = new AntdUI.Checkbox();
            checkbox1 = new AntdUI.Checkbox();
            label5 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 332);
            button1.Name = "button1";
            button1.Size = new Size(167, 52);
            button1.TabIndex = 14;
            button1.Text = "确定";
            button1.Click += button1_Click;
            // 
            // input3
            // 
            input3.Location = new Point(299, 222);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入内容";
            input3.Size = new Size(283, 51);
            input3.TabIndex = 11;
            // 
            // input2
            // 
            input2.Location = new Point(299, 173);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入内容";
            input2.Size = new Size(283, 51);
            input2.TabIndex = 12;
            // 
            // input1
            // 
            input1.Location = new Point(299, 126);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入内容";
            input1.Size = new Size(283, 51);
            input1.TabIndex = 13;
            // 
            // checkbox2
            // 
            checkbox2.Location = new Point(425, 294);
            checkbox2.Name = "checkbox2";
            checkbox2.Size = new Size(75, 23);
            checkbox2.TabIndex = 9;
            checkbox2.Text = "女";
            checkbox2.CheckedChanged += checkbox2_CheckedChanged;
            // 
            // checkbox1
            // 
            checkbox1.Location = new Point(299, 294);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(75, 23);
            checkbox1.TabIndex = 10;
            checkbox1.Text = "男";
            checkbox1.CheckedChanged += checkbox1_CheckedChanged;
            // 
            // label5
            // 
            label5.Font = new Font("楷体", 12F);
            label5.Location = new Point(218, 294);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 4;
            label5.Text = "性别";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("楷体", 12F);
            label4.Location = new Point(222, 237);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 5;
            label4.Text = "手机号";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("楷体", 12F);
            label3.Location = new Point(222, 188);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 6;
            label3.Text = "身份证号码";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("楷体", 12F);
            label2.Location = new Point(222, 140);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 7;
            label2.Text = "姓名";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(330, 67);
            label1.Name = "label1";
            label1.Size = new Size(153, 41);
            label1.TabIndex = 8;
            label1.Text = "客户信息编辑";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customeredit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(checkbox2);
            Controls.Add(checkbox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customeredit";
            Text = "edit";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
    }
}