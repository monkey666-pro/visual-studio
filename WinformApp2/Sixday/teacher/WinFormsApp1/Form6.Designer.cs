namespace WinFormsApp1
{
    partial class Form6
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
            button2 = new AntdUI.Button();
            inputNumber1 = new AntdUI.InputNumber();
            select1 = new AntdUI.Select();
            progress1 = new AntdUI.Progress();
            timePicker1 = new AntdUI.TimePicker();
            datePickerRange1 = new AntdUI.DatePickerRange();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Shape = AntdUI.TShape.Round;
            button1.Size = new Size(242, 108);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // button2
            // 
            button2.BorderWidth = 4F;
            button2.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Ghost = true;
            button2.Location = new Point(279, 12);
            button2.Name = "button2";
            button2.Shape = AntdUI.TShape.Round;
            button2.Size = new Size(242, 108);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.Type = AntdUI.TTypeMini.Primary;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(33, 157);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(188, 68);
            inputNumber1.TabIndex = 1;
            inputNumber1.Text = "0";
            // 
            // select1
            // 
            select1.Items.AddRange(new object[] { "苹果", "香蕉", "橙子", "榴莲" });
            select1.Location = new Point(278, 157);
            select1.Name = "select1";
            select1.Size = new Size(224, 68);
            select1.TabIndex = 2;
            select1.Text = "选水果";
            // 
            // progress1
            // 
            progress1.Location = new Point(527, 105);
            progress1.Name = "progress1";
            progress1.Shape = AntdUI.TShapeProgress.Circle;
            progress1.Size = new Size(200, 84);
            progress1.TabIndex = 3;
            progress1.Text = "progress1";
            progress1.Value = 0.5F;
            // 
            // timePicker1
            // 
            timePicker1.Location = new Point(33, 298);
            timePicker1.Name = "timePicker1";
            timePicker1.Size = new Size(174, 85);
            timePicker1.TabIndex = 4;
            timePicker1.Text = "00:00:00";
            // 
            // datePickerRange1
            // 
            datePickerRange1.Location = new Point(278, 286);
            datePickerRange1.Name = "datePickerRange1";
            datePickerRange1.Size = new Size(289, 97);
            datePickerRange1.TabIndex = 5;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datePickerRange1);
            Controls.Add(timePicker1);
            Controls.Add(progress1);
            Controls.Add(select1);
            Controls.Add(inputNumber1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Select select1;
        private AntdUI.Progress progress1;
        private AntdUI.TimePicker timePicker1;
        private AntdUI.DatePickerRange datePickerRange1;
    }
}