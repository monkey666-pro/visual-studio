namespace WinFormsApp1.carrent
{
    partial class carreturn
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
            label1 = new AntdUI.Label();
            table1 = new AntdUI.Table();
            input1 = new AntdUI.Input();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 50);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 5;
            button1.Text = "刷新";
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(343, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 34);
            label1.TabIndex = 4;
            label1.Text = "已借车辆";
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(61, 90);
            table1.Name = "table1";
            table1.Size = new Size(679, 322);
            table1.TabIndex = 3;
            table1.Text = "table1";
            // 
            // input1
            // 
            input1.Location = new Point(618, 55);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入文本";
            input1.Size = new Size(111, 29);
            input1.TabIndex = 6;
            // 
            // carreturn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(input1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(table1);
            Name = "carreturn";
            Text = "carreturn";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Label label1;
        private AntdUI.Table table1;
        private AntdUI.Input input1;
    }
}