namespace nineday.book
{
    partial class add
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
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            button5 = new AntdUI.Button();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            inputNumber1 = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(269, 93);
            label1.Name = "label1";
            label1.Size = new Size(93, 49);
            label1.TabIndex = 1;
            label1.Text = "员工姓名";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 65);
            label2.TabIndex = 2;
            label2.Text = "员工新增";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(269, 172);
            label3.Name = "label3";
            label3.Size = new Size(93, 49);
            label3.TabIndex = 1;
            label3.Text = "部门";
            // 
            // label4
            // 
            label4.Location = new Point(269, 250);
            label4.Name = "label4";
            label4.Size = new Size(93, 49);
            label4.TabIndex = 1;
            label4.Text = "薪资";
            // 
            // label5
            // 
            label5.Location = new Point(269, 317);
            label5.Name = "label5";
            label5.Size = new Size(93, 49);
            label5.TabIndex = 1;
            label5.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(303, 389);
            button5.Name = "button5";
            button5.Size = new Size(162, 49);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.Click += button5_Click;
            // 
            // input1
            // 
            input1.Location = new Point(352, 93);
            input1.Name = "input1";
            input1.Size = new Size(264, 57);
            input1.TabIndex = 3;
            // 
            // input2
            // 
            input2.Location = new Point(352, 172);
            input2.Name = "input2";
            input2.Size = new Size(264, 57);
            input2.TabIndex = 3;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(352, 250);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(255, 43);
            inputNumber1.TabIndex = 4;
            inputNumber1.Text = "0";
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputNumber1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(label1);
            Name = "add";
            Text = "add";
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Button button5;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.InputNumber inputNumber1;
    }
}