﻿namespace GuiForDentalA
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            textBox8 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 384);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(294, 342);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(294, 297);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(294, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 8;
            label1.Text = "First name: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 120);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 9;
            label2.Text = "Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 166);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 10;
            label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 207);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Gender: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 253);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 300);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 13;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 345);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(216, 387);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 15;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(157, 420);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 17;
            label9.Text = "Re enter Password:";
            label9.Click += label9_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(294, 417);
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '*';
            textBox7.Size = new Size(250, 27);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(362, 462);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(294, 207);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(250, 27);
            textBox8.TabIndex = 19;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(694, 444);
            button2.Name = "button2";
            button2.Size = new Size(94, 64);
            button2.TabIndex = 20;
            button2.Text = "Return to log in page ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 538);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private Button button1;
        private TextBox textBox8;
        private Button button2;
    }
}