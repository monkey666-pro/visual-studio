namespace WinFormsApp1.car
{
    partial class caredit
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
            inputNumber1 = new AntdUI.InputNumber();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            时租费 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 327);
            button1.Name = "button1";
            button1.Size = new Size(163, 50);
            button1.TabIndex = 11;
            button1.Text = "编辑";
            button1.Click += button1_Click;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(336, 245);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入价格";
            inputNumber1.Size = new Size(252, 39);
            inputNumber1.TabIndex = 10;
            inputNumber1.Text = "0";
            inputNumber1.TextAlign = HorizontalAlignment.Center;
            // 
            // input2
            // 
            input2.Location = new Point(314, 177);
            input2.Name = "input2";
            input2.PlaceholderColorExtend = "";
            input2.PlaceholderText = "请输入内容";
            input2.Size = new Size(306, 47);
            input2.TabIndex = 8;
            input2.TextAlign = HorizontalAlignment.Center;
            // 
            // input1
            // 
            input1.Location = new Point(314, 124);
            input1.Name = "input1";
            input1.PlaceholderColorExtend = "";
            input1.PlaceholderText = "请输入内容";
            input1.Size = new Size(306, 47);
            input1.TabIndex = 9;
            input1.TextAlign = HorizontalAlignment.Center;
            // 
            // 时租费
            // 
            时租费.Location = new Point(180, 245);
            时租费.Name = "时租费";
            时租费.Size = new Size(75, 23);
            时租费.TabIndex = 4;
            时租费.Text = "时租费";
            // 
            // label3
            // 
            label3.Location = new Point(180, 190);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 5;
            label3.Text = "车辆类型";
            // 
            // label2
            // 
            label2.Location = new Point(180, 133);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 6;
            label2.Text = "车牌号";
            // 
            // label1
            // 
            label1.Location = new Point(350, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 7;
            label1.Text = "车辆编辑";
            // 
            // caredit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(inputNumber1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(时租费);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "caredit";
            Text = "caredit";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Label 时租费;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
    }
}