namespace WinFormsApp1.car
{
    partial class caradd
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
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            时租费 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            inputNumber1 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(346, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(176, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 0;
            label2.Text = "车牌号";
            // 
            // label3
            // 
            label3.Location = new Point(176, 139);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 0;
            label3.Text = "车辆类型";
            // 
            // 时租费
            // 
            时租费.Location = new Point(176, 194);
            时租费.Name = "时租费";
            时租费.Size = new Size(75, 23);
            时租费.TabIndex = 0;
            时租费.Text = "时租费";
            // 
            // input1
            // 
            input1.Location = new Point(310, 73);
            input1.Name = "input1";
            input1.PlaceholderColorExtend = "";
            input1.PlaceholderText = "请输入内容";
            input1.Size = new Size(306, 47);
            input1.TabIndex = 1;
            input1.TextAlign = HorizontalAlignment.Center;
            // 
            // input2
            // 
            input2.Location = new Point(310, 126);
            input2.Name = "input2";
            input2.PlaceholderColorExtend = "";
            input2.PlaceholderText = "请输入内容";
            input2.Size = new Size(306, 47);
            input2.TabIndex = 1;
            input2.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(332, 194);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入价格";
            inputNumber1.Size = new Size(252, 39);
            inputNumber1.TabIndex = 2;
            inputNumber1.Text = "0";
            inputNumber1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(337, 276);
            button1.Name = "button1";
            button1.Size = new Size(163, 50);
            button1.TabIndex = 3;
            button1.Text = "新增";
            button1.Click += button1_Click;
            // 
            // caradd
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
            Name = "caradd";
            Text = "caradd";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label 时租费;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button button1;
    }
}