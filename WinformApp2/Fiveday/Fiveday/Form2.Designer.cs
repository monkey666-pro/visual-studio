namespace Fiveday
{
    partial class Form2
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
            all = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // all
            // 
            all.AutoSize = true;
            all.Location = new Point(143, 39);
            all.Name = "all";
            all.Size = new Size(51, 21);
            all.TabIndex = 0;
            all.Text = "全选";
            all.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 13);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 21);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "香蕉";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 40);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(51, 21);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "苹果";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(27, 68);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(51, 21);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "西瓜";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(27, 95);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(51, 21);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "荔枝";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(27, 122);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(51, 21);
            checkBox6.TabIndex = 0;
            checkBox6.Text = "龙眼";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(27, 155);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(51, 21);
            checkBox7.TabIndex = 0;
            checkBox7.Text = "芒果";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox7);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox5);
            panel1.Location = new Point(171, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 180);
            panel1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(all);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox all;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Panel panel1;
    }
}