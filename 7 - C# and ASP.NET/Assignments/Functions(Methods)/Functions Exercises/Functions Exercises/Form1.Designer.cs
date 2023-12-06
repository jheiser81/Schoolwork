namespace Functions_Exercises
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Chk_Bal_btn = new System.Windows.Forms.Button();
            this.Withdraw_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 300);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chk_Bal_btn
            // 
            this.Chk_Bal_btn.Location = new System.Drawing.Point(396, 12);
            this.Chk_Bal_btn.Name = "Chk_Bal_btn";
            this.Chk_Bal_btn.Size = new System.Drawing.Size(134, 29);
            this.Chk_Bal_btn.TabIndex = 2;
            this.Chk_Bal_btn.Text = "Check Balance";
            this.Chk_Bal_btn.UseVisualStyleBackColor = true;
            this.Chk_Bal_btn.Click += new System.EventHandler(this.Chk_Bal_btn_Click);
            // 
            // Withdraw_btn
            // 
            this.Withdraw_btn.Location = new System.Drawing.Point(396, 47);
            this.Withdraw_btn.Name = "Withdraw_btn";
            this.Withdraw_btn.Size = new System.Drawing.Size(134, 29);
            this.Withdraw_btn.TabIndex = 3;
            this.Withdraw_btn.Text = "Withdraw";
            this.Withdraw_btn.UseVisualStyleBackColor = true;
            this.Withdraw_btn.Click += new System.EventHandler(this.Withdraw_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount to withdraw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Withdraw_btn);
            this.Controls.Add(this.Chk_Bal_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button Chk_Bal_btn;
        private Button Withdraw_btn;
        private TextBox textBox1;
        private Label label1;
    }
}