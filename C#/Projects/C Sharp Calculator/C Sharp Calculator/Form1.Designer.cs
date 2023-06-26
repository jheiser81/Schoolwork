namespace C_Sharp_Calculator
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
            this.displayBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.clr_btn = new System.Windows.Forms.Button();
            this.eq_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.decimal_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(295, 58);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(209, 27);
            this.displayBox.TabIndex = 58;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(295, 89);
            this.resultBox.Name = "resultBox";
            this.resultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultBox.Size = new System.Drawing.Size(209, 81);
            this.resultBox.TabIndex = 57;
            this.resultBox.Text = "";
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(453, 359);
            this.clr_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(53, 27);
            this.clr_btn.TabIndex = 56;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // eq_btn
            // 
            this.eq_btn.Location = new System.Drawing.Point(295, 359);
            this.eq_btn.Margin = new System.Windows.Forms.Padding(2);
            this.eq_btn.Name = "eq_btn";
            this.eq_btn.Size = new System.Drawing.Size(53, 27);
            this.eq_btn.TabIndex = 55;
            this.eq_btn.Text = "=";
            this.eq_btn.UseVisualStyleBackColor = true;
            this.eq_btn.Click += new System.EventHandler(this.eq_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(374, 359);
            this.del_btn.Margin = new System.Windows.Forms.Padding(2);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(53, 27);
            this.del_btn.TabIndex = 54;
            this.del_btn.Text = "Del";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // decimal_btn
            // 
            this.decimal_btn.Location = new System.Drawing.Point(374, 283);
            this.decimal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.decimal_btn.Name = "decimal_btn";
            this.decimal_btn.Size = new System.Drawing.Size(53, 27);
            this.decimal_btn.TabIndex = 53;
            this.decimal_btn.Text = ".";
            this.decimal_btn.UseVisualStyleBackColor = true;
            this.decimal_btn.Click += new System.EventHandler(this.decimal_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.Location = new System.Drawing.Point(453, 322);
            this.div_btn.Margin = new System.Windows.Forms.Padding(2);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(53, 27);
            this.div_btn.TabIndex = 52;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // mult_btn
            // 
            this.mult_btn.Location = new System.Drawing.Point(374, 322);
            this.mult_btn.Margin = new System.Windows.Forms.Padding(2);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(53, 27);
            this.mult_btn.TabIndex = 51;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = true;
            this.mult_btn.Click += new System.EventHandler(this.mult_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(295, 322);
            this.sub_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(53, 27);
            this.sub_btn.TabIndex = 50;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(453, 283);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(53, 27);
            this.add_btn.TabIndex = 49;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(295, 283);
            this.Button10.Margin = new System.Windows.Forms.Padding(2);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(53, 27);
            this.Button10.TabIndex = 48;
            this.Button10.Text = "0";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(451, 247);
            this.Button9.Margin = new System.Windows.Forms.Padding(2);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(53, 27);
            this.Button9.TabIndex = 47;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(374, 247);
            this.Button8.Margin = new System.Windows.Forms.Padding(2);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(53, 27);
            this.Button8.TabIndex = 46;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(295, 247);
            this.Button7.Margin = new System.Windows.Forms.Padding(2);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(51, 27);
            this.Button7.TabIndex = 45;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(453, 211);
            this.Button6.Margin = new System.Windows.Forms.Padding(2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(53, 27);
            this.Button6.TabIndex = 44;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(374, 211);
            this.Button5.Margin = new System.Windows.Forms.Padding(2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(53, 27);
            this.Button5.TabIndex = 43;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(295, 211);
            this.Button4.Margin = new System.Windows.Forms.Padding(2);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(51, 27);
            this.Button4.TabIndex = 42;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(453, 175);
            this.Button3.Margin = new System.Windows.Forms.Padding(2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(53, 27);
            this.Button3.TabIndex = 41;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(374, 175);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(53, 27);
            this.Button2.TabIndex = 40;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(295, 175);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(51, 27);
            this.Button1.TabIndex = 39;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RichTextBox1.Location = new System.Drawing.Point(289, 49);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(223, 353);
            this.RichTextBox1.TabIndex = 38;
            this.RichTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.eq_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.decimal_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.RichTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal TextBox displayBox;
        internal RichTextBox resultBox;
        internal Button clr_btn;
        internal Button eq_btn;
        internal Button del_btn;
        internal Button decimal_btn;
        internal Button div_btn;
        internal Button mult_btn;
        internal Button sub_btn;
        internal Button add_btn;
        internal Button Button10;
        internal Button Button9;
        internal Button Button8;
        internal Button Button7;
        internal Button Button6;
        internal Button Button5;
        internal Button Button4;
        internal Button Button3;
        internal Button Button2;
        internal Button Button1;
        internal RichTextBox RichTextBox1;
    }
}