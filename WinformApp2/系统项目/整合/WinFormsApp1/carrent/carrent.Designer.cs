namespace WinFormsApp1.carrent
{
    partial class carrent
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
            table1 = new AntdUI.Table();
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            input1 = new AntdUI.Input();
            SuspendLayout();
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(52, 64);
            table1.Name = "table1";
            table1.Size = new Size(679, 322);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // label1
            // 
            label1.Font = new Font("楷体", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(334, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 34);
            label1.TabIndex = 1;
            label1.Text = "空闲车辆";
            // 
            // button1
            // 
            button1.Location = new Point(52, 24);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 2;
            button1.Text = "刷新";
            button1.Click += button1_Click;
            // 
            // input1
            // 
            input1.Location = new Point(603, 24);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入客户id";
            input1.Size = new Size(116, 34);
            input1.TabIndex = 3;
            
            // 
            // carrent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(input1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(table1);
            Name = "carrent";
            Text = "rentshow";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Input input1;
    }
}