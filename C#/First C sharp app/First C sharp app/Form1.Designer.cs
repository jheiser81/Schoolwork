namespace First_C_sharp_app
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
            this.add_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.diff_btn = new System.Windows.Forms.Button();
            this.prod_btn = new System.Windows.Forms.Button();
            this.quot_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.swap_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_btn.Location = new System.Drawing.Point(193, 54);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(131, 40);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 35);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 35);
            this.textBox3.TabIndex = 4;
            // 
            // diff_btn
            // 
            this.diff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diff_btn.Location = new System.Drawing.Point(193, 100);
            this.diff_btn.Name = "diff_btn";
            this.diff_btn.Size = new System.Drawing.Size(131, 40);
            this.diff_btn.TabIndex = 5;
            this.diff_btn.Text = "-";
            this.diff_btn.UseVisualStyleBackColor = false;
            this.diff_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // prod_btn
            // 
            this.prod_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prod_btn.Location = new System.Drawing.Point(193, 146);
            this.prod_btn.Name = "prod_btn";
            this.prod_btn.Size = new System.Drawing.Size(131, 40);
            this.prod_btn.TabIndex = 6;
            this.prod_btn.Text = "*";
            this.prod_btn.UseVisualStyleBackColor = false;
            this.prod_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // quot_btn
            // 
            this.quot_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quot_btn.Location = new System.Drawing.Point(193, 192);
            this.quot_btn.Name = "quot_btn";
            this.quot_btn.Size = new System.Drawing.Size(131, 40);
            this.quot_btn.TabIndex = 7;
            this.quot_btn.Text = "/";
            this.quot_btn.UseVisualStyleBackColor = false;
            this.quot_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Num2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(377, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(411, 35);
            this.textBox4.TabIndex = 10;
            // 
            // swap_btn
            // 
            this.swap_btn.Location = new System.Drawing.Point(520, 100);
            this.swap_btn.Name = "swap_btn";
            this.swap_btn.Size = new System.Drawing.Size(131, 40);
            this.swap_btn.TabIndex = 11;
            this.swap_btn.Text = "Swap";
            this.swap_btn.UseVisualStyleBackColor = true;
            this.swap_btn.Click += new System.EventHandler(this.swap_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Num1=55";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Num2=60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swap_btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quot_btn);
            this.Controls.Add(this.prod_btn);
            this.Controls.Add(this.diff_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button diff_btn;
        private Button prod_btn;
        private Button quot_btn;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Button swap_btn;
        private Label label3;
        private Label label4;
    }
}