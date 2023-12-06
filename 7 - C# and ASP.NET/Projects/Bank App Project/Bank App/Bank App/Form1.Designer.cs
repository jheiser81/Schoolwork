namespace Bank_App
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
            label1 = new Label();
            Cust_ID_box = new TextBox();
            find_ID_btn = new Button();
            prev_btn = new Button();
            button5 = new Button();
            del_btn = new Button();
            dob_box = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            email_box = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            next_btn = new Button();
            pc_box = new TextBox();
            street_no_box = new TextBox();
            city_box = new TextBox();
            street_name_box = new TextBox();
            phone_box = new TextBox();
            update_btn = new Button();
            Lname_box = new TextBox();
            Fname_box = new TextBox();
            Read = new Button();
            insert_btn = new Button();
            prov_box = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 251);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 69;
            label1.Text = "Customer ID";
            // 
            // Cust_ID_box
            // 
            Cust_ID_box.CausesValidation = false;
            Cust_ID_box.Location = new Point(15, 259);
            Cust_ID_box.Margin = new Padding(4, 4, 4, 4);
            Cust_ID_box.Name = "Cust_ID_box";
            Cust_ID_box.Size = new Size(155, 31);
            Cust_ID_box.TabIndex = 10;
            // 
            // find_ID_btn
            // 
            find_ID_btn.Location = new Point(172, 308);
            find_ID_btn.Margin = new Padding(2);
            find_ID_btn.Name = "find_ID_btn";
            find_ID_btn.Size = new Size(118, 34);
            find_ID_btn.TabIndex = 67;
            find_ID_btn.Text = "Find ID";
            find_ID_btn.UseVisualStyleBackColor = true;
            find_ID_btn.Click += find_ID_btn_Click;
            // 
            // prev_btn
            // 
            prev_btn.Location = new Point(172, 390);
            prev_btn.Margin = new Padding(2);
            prev_btn.Name = "prev_btn";
            prev_btn.Size = new Size(118, 34);
            prev_btn.TabIndex = 66;
            prev_btn.Text = "Previous ";
            prev_btn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(15, 490);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(198, 34);
            button5.TabIndex = 65;
            button5.Text = "Get Accounts";
            button5.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            del_btn.Location = new Point(15, 390);
            del_btn.Margin = new Padding(2);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(118, 34);
            del_btn.TabIndex = 64;
            del_btn.Text = "Delete";
            del_btn.UseVisualStyleBackColor = true;
            // 
            // dob_box
            // 
            dob_box.Format = DateTimePickerFormat.Short;
            dob_box.Location = new Point(334, 215);
            dob_box.Margin = new Padding(2);
            dob_box.Name = "dob_box";
            dob_box.Size = new Size(155, 31);
            dob_box.TabIndex = 63;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(188, 140);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 25);
            label13.TabIndex = 62;
            label13.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(511, 58);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(91, 25);
            label12.TabIndex = 61;
            label12.Text = "Phone No";
            // 
            // email_box
            // 
            email_box.Location = new Point(15, 140);
            email_box.Margin = new Padding(4, 4, 4, 4);
            email_box.Name = "email_box";
            email_box.Size = new Size(155, 31);
            email_box.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(511, 174);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 25);
            label10.TabIndex = 56;
            label10.Text = "Postal Code";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 92);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 55;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 218);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 54;
            label8.Text = "Street Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 101);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 53;
            label7.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 132);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 52;
            label5.Text = "Province";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 179);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 51;
            label4.Text = "Street Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 212);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 50;
            label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 49;
            label2.Text = "First Name";
            // 
            // next_btn
            // 
            next_btn.Location = new Point(172, 350);
            next_btn.Margin = new Padding(2);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(118, 34);
            next_btn.TabIndex = 48;
            next_btn.Text = "Next";
            next_btn.UseVisualStyleBackColor = true;
            // 
            // pc_box
            // 
            pc_box.Location = new Point(334, 174);
            pc_box.Margin = new Padding(4, 4, 4, 4);
            pc_box.Name = "pc_box";
            pc_box.Size = new Size(155, 31);
            pc_box.TabIndex = 9;
            // 
            // street_no_box
            // 
            street_no_box.Location = new Point(15, 218);
            street_no_box.Margin = new Padding(4, 4, 4, 4);
            street_no_box.Name = "street_no_box";
            street_no_box.Size = new Size(155, 31);
            street_no_box.TabIndex = 5;
            // 
            // city_box
            // 
            city_box.Location = new Point(334, 96);
            city_box.Margin = new Padding(4, 4, 4, 4);
            city_box.Name = "city_box";
            city_box.Size = new Size(155, 31);
            city_box.TabIndex = 7;
            // 
            // street_name_box
            // 
            street_name_box.Location = new Point(15, 179);
            street_name_box.Margin = new Padding(4, 4, 4, 4);
            street_name_box.Name = "street_name_box";
            street_name_box.Size = new Size(155, 31);
            street_name_box.TabIndex = 4;
            // 
            // phone_box
            // 
            phone_box.Location = new Point(334, 58);
            phone_box.Margin = new Padding(4, 4, 4, 4);
            phone_box.Name = "phone_box";
            phone_box.Size = new Size(155, 31);
            phone_box.TabIndex = 6;
            // 
            // update_btn
            // 
            update_btn.FlatStyle = FlatStyle.System;
            update_btn.Location = new Point(15, 348);
            update_btn.Margin = new Padding(4, 4, 4, 4);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(118, 36);
            update_btn.TabIndex = 42;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // Lname_box
            // 
            Lname_box.Location = new Point(15, 101);
            Lname_box.Margin = new Padding(4, 4, 4, 4);
            Lname_box.Name = "Lname_box";
            Lname_box.Size = new Size(155, 31);
            Lname_box.TabIndex = 2;
            // 
            // Fname_box
            // 
            Fname_box.Location = new Point(15, 60);
            Fname_box.Margin = new Padding(4, 4, 4, 4);
            Fname_box.Name = "Fname_box";
            Fname_box.Size = new Size(155, 31);
            Fname_box.TabIndex = 1;
            // 
            // Read
            // 
            Read.Location = new Point(15, 452);
            Read.Margin = new Padding(2);
            Read.Name = "Read";
            Read.Size = new Size(198, 34);
            Read.TabIndex = 39;
            Read.Text = "Show All Customers";
            Read.UseVisualStyleBackColor = true;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(15, 308);
            insert_btn.Margin = new Padding(2);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(118, 34);
            insert_btn.TabIndex = 38;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // prov_box
            // 
            prov_box.Location = new Point(334, 135);
            prov_box.Margin = new Padding(4, 4, 4, 4);
            prov_box.Name = "prov_box";
            prov_box.Size = new Size(155, 31);
            prov_box.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 663);
            Controls.Add(prov_box);
            Controls.Add(label1);
            Controls.Add(Cust_ID_box);
            Controls.Add(find_ID_btn);
            Controls.Add(prev_btn);
            Controls.Add(button5);
            Controls.Add(del_btn);
            Controls.Add(dob_box);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(email_box);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(next_btn);
            Controls.Add(pc_box);
            Controls.Add(street_no_box);
            Controls.Add(city_box);
            Controls.Add(street_name_box);
            Controls.Add(phone_box);
            Controls.Add(update_btn);
            Controls.Add(Lname_box);
            Controls.Add(Fname_box);
            Controls.Add(Read);
            Controls.Add(insert_btn);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Cust_ID_box;
        private Button find_ID_btn;
        private Button prev_btn;
        private Button button5;
        private Button del_btn;
        private DateTimePicker dob_box;
        private Label label13;
        private Label label12;
        private TextBox email_box;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button next_btn;
        private TextBox pc_box;
        private TextBox street_no_box;
        private TextBox city_box;
        private TextBox street_name_box;
        private TextBox phone_box;
        private Button update_btn;
        private TextBox Lname_box;
        private TextBox Fname_box;
        private Button Read;
        private Button insert_btn;
        private TextBox prov_box;
    }
}