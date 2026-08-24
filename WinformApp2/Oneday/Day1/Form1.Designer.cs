namespace Day1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            注册按钮 = new Button();
            user = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // 注册按钮
            // 
            注册按钮.ForeColor = Color.Red;
            注册按钮.Location = new Point(260, 29);
            注册按钮.Margin = new Padding(3, 2, 3, 2);
            注册按钮.Name = "注册按钮";
            注册按钮.Size = new Size(118, 39);
            注册按钮.TabIndex = 2;
            注册按钮.Text = "注册";
            注册按钮.UseVisualStyleBackColor = true;
            注册按钮.Click += button1_Click;
            // 
            // user
            // 
            user.AutoSize = true;
            user.BorderStyle = BorderStyle.Fixed3D;
            user.Location = new Point(149, 83);
            user.Name = "user";
            user.Size = new Size(51, 16);
            user.TabIndex = 2;
            user.Text = "用户名";
            user.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(149, 114);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 2;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(149, 145);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 2;
            label3.Text = "确认密码";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 80);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "请输入用户名";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 113);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "请输入密码";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 142);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "请再次输入密码";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(260, 249);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 39);
            button1.TabIndex = 2;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(149, 195);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 2;
            label1.Text = "性别";
            label1.Click += label1_Click_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(149, 228);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 2;
            label4.Text = "爱好";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(211, 195);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(39, 18);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "男\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(326, 195);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(39, 18);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(441, 195);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 18);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "保密";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "游戏", "打球", "旅游", "音乐", "登山", "跑步" });
            comboBox1.Location = new Point(227, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 22);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(498, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(399, 311);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(95, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 83);
            label5.Name = "label5";
            label5.Size = new Size(77, 14);
            label5.TabIndex = 2;
            label5.Text = "长度为3-10";
            label5.Click += label1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 120);
            label6.Name = "label6";
            label6.Size = new Size(63, 14);
            label6.TabIndex = 2;
            label6.Text = "长度8-15";
            label6.Click += label1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 151);
            label7.Name = "label7";
            label7.Size = new Size(63, 14);
            label7.TabIndex = 2;
            label7.Text = "长度8-15";
            label7.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(48, 83);
            label8.Name = "label8";
            label8.Size = new Size(65, 16);
            label8.TabIndex = 2;
            label8.Text = "用户头像";
            label8.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(31, 230);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 2;
            button2.Text = "确定";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(363, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 18);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "唱";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(405, 227);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(40, 18);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "跳";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(441, 227);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(47, 18);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "rab";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 380);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(user);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(注册按钮);
            Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "窗体一";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button 注册按钮;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        public Label user;
        private Button button1;
        private Label label1;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        public Label label5;
        public Label label6;
        public Label label7;
        private PictureBox pictureBox1;
        public Label label8;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
