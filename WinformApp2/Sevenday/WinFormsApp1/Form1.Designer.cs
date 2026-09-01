namespace WinFormsApp1
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(41, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 329);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new Point(268, 134);
            button1.Name = "button1";
            button1.Size = new Size(81, 62);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(416, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 329);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
