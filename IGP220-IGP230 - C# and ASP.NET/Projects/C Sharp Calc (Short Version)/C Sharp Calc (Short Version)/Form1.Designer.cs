namespace C_Sharp_Calc__Short_Version_
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
            displayBox = new TextBox();
            resultBox = new RichTextBox();
            clr_btn = new Button();
            eq_btn = new Button();
            del_btn = new Button();
            decimal_btn = new Button();
            div_btn = new Button();
            mult_btn = new Button();
            sub_btn = new Button();
            add_btn = new Button();
            Button10 = new Button();
            Button9 = new Button();
            Button8 = new Button();
            Button7 = new Button();
            Button6 = new Button();
            Button5 = new Button();
            Button4 = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            RichTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Location = new Point(342, 228);
            displayBox.Margin = new Padding(4);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(264, 31);
            displayBox.TabIndex = 79;
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Segoe UI", 15.85714F, FontStyle.Regular, GraphicsUnit.Point);
            resultBox.Location = new Point(342, 266);
            resultBox.Margin = new Padding(4);
            resultBox.Name = "resultBox";
            resultBox.RightToLeft = RightToLeft.No;
            resultBox.Size = new Size(264, 100);
            resultBox.TabIndex = 78;
            resultBox.Text = "";
            // 
            // clr_btn
            // 
            clr_btn.Location = new Point(540, 604);
            clr_btn.Margin = new Padding(2);
            clr_btn.Name = "clr_btn";
            clr_btn.Size = new Size(66, 34);
            clr_btn.TabIndex = 77;
            clr_btn.Text = "Clear";
            clr_btn.UseVisualStyleBackColor = true;
            clr_btn.Click += clr_btn_Click;
            // 
            // eq_btn
            // 
            eq_btn.Location = new Point(342, 604);
            eq_btn.Margin = new Padding(2);
            eq_btn.Name = "eq_btn";
            eq_btn.Size = new Size(66, 34);
            eq_btn.TabIndex = 76;
            eq_btn.Text = "=";
            eq_btn.UseVisualStyleBackColor = true;
            eq_btn.Click += eq_btn_Click;
            // 
            // del_btn
            // 
            del_btn.Location = new Point(441, 604);
            del_btn.Margin = new Padding(2);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(66, 34);
            del_btn.TabIndex = 75;
            del_btn.Text = "Del";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += del_btn_Click;
            // 
            // decimal_btn
            // 
            decimal_btn.Location = new Point(441, 509);
            decimal_btn.Margin = new Padding(2);
            decimal_btn.Name = "decimal_btn";
            decimal_btn.Size = new Size(66, 34);
            decimal_btn.TabIndex = 74;
            decimal_btn.Text = ".";
            decimal_btn.UseVisualStyleBackColor = true;
            decimal_btn.Click += decimal_btn_Click;
            // 
            // div_btn
            // 
            div_btn.Location = new Point(540, 558);
            div_btn.Margin = new Padding(2);
            div_btn.Name = "div_btn";
            div_btn.Size = new Size(66, 34);
            div_btn.TabIndex = 73;
            div_btn.Text = "/";
            div_btn.UseVisualStyleBackColor = true;
            div_btn.Click += div_click;
            // 
            // mult_btn
            // 
            mult_btn.Location = new Point(441, 558);
            mult_btn.Margin = new Padding(2);
            mult_btn.Name = "mult_btn";
            mult_btn.Size = new Size(66, 34);
            mult_btn.TabIndex = 72;
            mult_btn.Text = "*";
            mult_btn.UseVisualStyleBackColor = true;
            mult_btn.Click += mult_click;
            // 
            // sub_btn
            // 
            sub_btn.Location = new Point(342, 558);
            sub_btn.Margin = new Padding(2);
            sub_btn.Name = "sub_btn";
            sub_btn.Size = new Size(66, 34);
            sub_btn.TabIndex = 71;
            sub_btn.Text = "-";
            sub_btn.UseVisualStyleBackColor = true;
            sub_btn.Click += sub_click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(540, 509);
            add_btn.Margin = new Padding(2);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(66, 34);
            add_btn.TabIndex = 70;
            add_btn.Text = "+";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_click;
            // 
            // Button10
            // 
            Button10.Location = new Point(342, 509);
            Button10.Margin = new Padding(2);
            Button10.Name = "Button10";
            Button10.Size = new Size(66, 34);
            Button10.TabIndex = 69;
            Button10.Text = "0";
            Button10.UseVisualStyleBackColor = true;
            Button10.Click += num_click;
            // 
            // Button9
            // 
            Button9.Location = new Point(538, 464);
            Button9.Margin = new Padding(2);
            Button9.Name = "Button9";
            Button9.Size = new Size(66, 34);
            Button9.TabIndex = 68;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += num_click;
            // 
            // Button8
            // 
            Button8.Location = new Point(441, 464);
            Button8.Margin = new Padding(2);
            Button8.Name = "Button8";
            Button8.Size = new Size(66, 34);
            Button8.TabIndex = 67;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += num_click;
            // 
            // Button7
            // 
            Button7.Location = new Point(342, 464);
            Button7.Margin = new Padding(2);
            Button7.Name = "Button7";
            Button7.Size = new Size(64, 34);
            Button7.TabIndex = 66;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += num_click;
            // 
            // Button6
            // 
            Button6.Location = new Point(540, 419);
            Button6.Margin = new Padding(2);
            Button6.Name = "Button6";
            Button6.Size = new Size(66, 34);
            Button6.TabIndex = 65;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += num_click;
            // 
            // Button5
            // 
            Button5.Location = new Point(441, 419);
            Button5.Margin = new Padding(2);
            Button5.Name = "Button5";
            Button5.Size = new Size(66, 34);
            Button5.TabIndex = 64;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += num_click;
            // 
            // Button4
            // 
            Button4.Location = new Point(342, 419);
            Button4.Margin = new Padding(2);
            Button4.Name = "Button4";
            Button4.Size = new Size(64, 34);
            Button4.TabIndex = 63;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += num_click;
            // 
            // Button3
            // 
            Button3.Location = new Point(540, 374);
            Button3.Margin = new Padding(2);
            Button3.Name = "Button3";
            Button3.Size = new Size(66, 34);
            Button3.TabIndex = 62;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += num_click;
            // 
            // Button2
            // 
            Button2.Location = new Point(441, 374);
            Button2.Margin = new Padding(2);
            Button2.Name = "Button2";
            Button2.Size = new Size(66, 34);
            Button2.TabIndex = 61;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += num_click;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.Window;
            Button1.Location = new Point(342, 374);
            Button1.Margin = new Padding(2);
            Button1.Name = "Button1";
            Button1.Size = new Size(64, 34);
            Button1.TabIndex = 60;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += num_click;
            // 
            // RichTextBox1
            // 
            RichTextBox1.BackColor = SystemColors.ControlDarkDark;
            RichTextBox1.Location = new Point(331, 216);
            RichTextBox1.Margin = new Padding(2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(287, 440);
            RichTextBox1.TabIndex = 59;
            RichTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 909);
            Controls.Add(displayBox);
            Controls.Add(resultBox);
            Controls.Add(clr_btn);
            Controls.Add(eq_btn);
            Controls.Add(del_btn);
            Controls.Add(decimal_btn);
            Controls.Add(div_btn);
            Controls.Add(mult_btn);
            Controls.Add(sub_btn);
            Controls.Add(add_btn);
            Controls.Add(Button10);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(RichTextBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Click += num_click;
            ResumeLayout(false);
            PerformLayout();
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