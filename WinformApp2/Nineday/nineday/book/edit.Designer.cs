namespace nineday.book
{
    partial class edit
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
            inputNumber1 = new AntdUI.InputNumber();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            button5 = new AntdUI.Button();
            SuspendLayout();
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(298, 275);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(255, 43);
            inputNumber1.TabIndex = 11;
            inputNumber1.Text = "0";
            // 
            // input2
            // 
            input2.Location = new Point(298, 197);
            input2.Name = "input2";
            input2.Size = new Size(264, 57);
            input2.TabIndex = 9;
            // 
            // input1
            // 
            input1.Location = new Point(298, 118);
            input1.Name = "input1";
            input1.Size = new Size(264, 57);
            input1.TabIndex = 10;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 65);
            label2.TabIndex = 8;
            label2.Text = "员工辞退";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(215, 275);
            label4.Name = "label4";
            label4.Size = new Size(93, 49);
            label4.TabIndex = 5;
            label4.Text = "id";
            // 
            // label3
            // 
            label3.Location = new Point(215, 197);
            label3.Name = "label3";
            label3.Size = new Size(93, 49);
            label3.TabIndex = 6;
            label3.Text = "部门";
            // 
            // label1
            // 
            label1.Location = new Point(215, 118);
            label1.Name = "label1";
            label1.Size = new Size(93, 49);
            label1.TabIndex = 7;
            label1.Text = "员工姓名";
            // 
            // button5
            // 
            button5.Location = new Point(310, 373);
            button5.Name = "button5";
            button5.Size = new Size(162, 49);
            button5.TabIndex = 12;
            button5.Text = "button1";
            // 
            // edit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(inputNumber1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "edit";
            Text = "add";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label1;
        private AntdUI.Button button5;
    }
}