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
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.g1TB = new System.Windows.Forms.TextBox();
            this.u1TB = new System.Windows.Forms.TextBox();
            this.g2TB = new System.Windows.Forms.TextBox();
            this.u2TB = new System.Windows.Forms.TextBox();
            this.g3TB = new System.Windows.Forms.TextBox();
            this.u3TB = new System.Windows.Forms.TextBox();
            this.avgButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avgTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(105, 51);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(125, 27);
            this.aTextBox.TabIndex = 0;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(105, 133);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(125, 27);
            this.bTextBox.TabIndex = 1;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(105, 236);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(94, 29);
            this.sumButton.TabIndex = 2;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(107, 203);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(125, 27);
            this.sumTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum:";
            // 
            // g1TB
            // 
            this.g1TB.Location = new System.Drawing.Point(375, 58);
            this.g1TB.Name = "g1TB";
            this.g1TB.Size = new System.Drawing.Size(125, 27);
            this.g1TB.TabIndex = 7;
            // 
            // u1TB
            // 
            this.u1TB.Location = new System.Drawing.Point(518, 58);
            this.u1TB.Name = "u1TB";
            this.u1TB.Size = new System.Drawing.Size(125, 27);
            this.u1TB.TabIndex = 8;
            // 
            // g2TB
            // 
            this.g2TB.Location = new System.Drawing.Point(375, 102);
            this.g2TB.Name = "g2TB";
            this.g2TB.Size = new System.Drawing.Size(125, 27);
            this.g2TB.TabIndex = 9;
            // 
            // u2TB
            // 
            this.u2TB.Location = new System.Drawing.Point(518, 102);
            this.u2TB.Name = "u2TB";
            this.u2TB.Size = new System.Drawing.Size(125, 27);
            this.u2TB.TabIndex = 10;
            // 
            // g3TB
            // 
            this.g3TB.Location = new System.Drawing.Point(375, 139);
            this.g3TB.Name = "g3TB";
            this.g3TB.Size = new System.Drawing.Size(125, 27);
            this.g3TB.TabIndex = 11;
            // 
            // u3TB
            // 
            this.u3TB.Location = new System.Drawing.Point(518, 139);
            this.u3TB.Name = "u3TB";
            this.u3TB.Size = new System.Drawing.Size(125, 27);
            this.u3TB.TabIndex = 12;
            // 
            // avgButton
            // 
            this.avgButton.Location = new System.Drawing.Point(454, 236);
            this.avgButton.Name = "avgButton";
            this.avgButton.Size = new System.Drawing.Size(94, 29);
            this.avgButton.TabIndex = 13;
            this.avgButton.Text = "Avg";
            this.avgButton.UseVisualStyleBackColor = true;
            this.avgButton.Click += new System.EventHandler(this.avgButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "g1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "g2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "g3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "u1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "u2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "u3";
            // 
            // avgTB
            // 
            this.avgTB.Location = new System.Drawing.Point(445, 189);
            this.avgTB.Name = "avgTB";
            this.avgTB.Size = new System.Drawing.Size(125, 27);
            this.avgTB.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "avg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 291);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.avgTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avgButton);
            this.Controls.Add(this.u3TB);
            this.Controls.Add(this.g3TB);
            this.Controls.Add(this.u2TB);
            this.Controls.Add(this.g2TB);
            this.Controls.Add(this.u1TB);
            this.Controls.Add(this.g1TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox aTextBox;
        private TextBox bTextBox;
        private Button sumButton;
        private TextBox sumTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox g1TB;
        private TextBox u1TB;
        private TextBox g2TB;
        private TextBox u2TB;
        private TextBox g3TB;
        private TextBox u3TB;
        private Button avgButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox avgTB;
        private Label label10;
    }
}