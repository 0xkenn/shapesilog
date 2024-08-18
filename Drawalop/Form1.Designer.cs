namespace Drawalop
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Circle";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(135, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Rectangle";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(14, 68);
            button1.Name = "button1";
            button1.Size = new Size(150, 49);
            button1.TabIndex = 2;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(320, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 83);
            panel1.TabIndex = 8;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(156, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(115, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Raster Based";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(116, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vector Based";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(596, 7);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 373);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Made With ❤️\nMembers:\nKenny Charles U. Tabon\nChristopher John Sinangote\nRomel Arinto\nNate Brazil\nCharlene hayahay\nEddieboy Ranes\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Location = new Point(304, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 38);
            panel2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Group Bridge Pattern CS 4C";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RichTextBox richTextBox1;
        private Panel panel2;
    }
}
