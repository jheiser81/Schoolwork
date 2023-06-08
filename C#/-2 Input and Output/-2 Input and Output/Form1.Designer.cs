namespace _2_Input_and_Output
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Concat_btn_1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.concat_btn_2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hello, ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "World!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Concat_btn_1
            // 
            this.Concat_btn_1.Location = new System.Drawing.Point(84, 225);
            this.Concat_btn_1.Name = "Concat_btn_1";
            this.Concat_btn_1.Size = new System.Drawing.Size(131, 40);
            this.Concat_btn_1.TabIndex = 2;
            this.Concat_btn_1.Text = "Concat";
            this.Concat_btn_1.UseVisualStyleBackColor = true;
            this.Concat_btn_1.Click += new System.EventHandler(this.Concat_btn_1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 35);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 35);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "William Blake";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 232);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "He who binds to himself a joy Does the winged life destroy; But he who kisses the" +
    " joy as it flies Lives in eternity\'s sun rise.\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(306, 348);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(262, 232);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // concat_btn_2
            // 
            this.concat_btn_2.Location = new System.Drawing.Point(237, 586);
            this.concat_btn_2.Name = "concat_btn_2";
            this.concat_btn_2.Size = new System.Drawing.Size(131, 40);
            this.concat_btn_2.TabIndex = 7;
            this.concat_btn_2.Text = "Concat";
            this.concat_btn_2.UseVisualStyleBackColor = true;
            this.concat_btn_2.Click += new System.EventHandler(this.concat_btn_2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 35);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Normal string concat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Using template literals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.concat_btn_2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Concat_btn_1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Concat_btn_1;
        private TextBox textBox3;
        private TextBox textBox4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button concat_btn_2;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
    }
}