namespace Library_Management_System
{
    partial class BooksManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksManagement));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            allbookpanel = new Panel();
            addpanel = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            deletepanel = new Panel();
            button7 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            issuedpanel = new Panel();
            label15 = new Label();
            dataGridView2 = new DataGridView();
            label10 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            allbookpanel.SuspendLayout();
            addpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            deletepanel.SuspendLayout();
            issuedpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(deletepanel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 88);
            panel1.TabIndex = 1;
            panel1.Paint += this.panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(300, 21);
            label1.Name = "label1";
            label1.Size = new Size(373, 42);
            label1.TabIndex = 2;
            label1.Text = "Central Public Library";
            label1.Click += this.label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(addpanel);
            panel2.Controls.Add(issuedpanel);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 559);
            panel2.TabIndex = 2;
            panel2.Paint += this.panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateBlue;
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(280, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(696, 65);
            panel3.TabIndex = 3;
            panel3.Paint += this.panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.FlatAppearance.BorderColor = Color.SpringGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSpringGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 132);
            button1.Name = "button1";
            button1.Size = new Size(225, 51);
            button1.TabIndex = 0;
            button1.Text = "View All Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.FlatAppearance.BorderColor = Color.SpringGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumSpringGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 217);
            button2.Name = "button2";
            button2.Size = new Size(225, 51);
            button2.TabIndex = 1;
            button2.Text = "Add Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.FlatAppearance.BorderColor = Color.SpringGreen;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumSpringGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 308);
            button3.Name = "button3";
            button3.Size = new Size(225, 51);
            button3.TabIndex = 2;
            button3.Text = "Delete Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += this.button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button5.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(249, 19);
            button5.Name = "button5";
            button5.Size = new Size(235, 34);
            button5.TabIndex = 0;
            button5.Text = "Back to DashBoard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += this.button5_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(255, 68);
            label3.TabIndex = 3;
            label3.Text = "Books Management";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += this.label3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SpringGreen;
            button6.FlatAppearance.BorderColor = Color.SpringGreen;
            button6.FlatAppearance.MouseOverBackColor = Color.MediumSpringGreen;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 398);
            button6.Name = "button6";
            button6.Size = new Size(225, 51);
            button6.TabIndex = 4;
            button6.Text = "Issued Books";
            button6.UseVisualStyleBackColor = false;
            button6.Click += this.button6_Click;
            // 
            // allbookpanel
            // 
            allbookpanel.BackColor = Color.MistyRose;
            allbookpanel.Controls.Add(dataGridView1);
            allbookpanel.Controls.Add(label2);
            allbookpanel.Location = new Point(280, 88);
            allbookpanel.Name = "allbookpanel";
            allbookpanel.Size = new Size(702, 507);
            allbookpanel.TabIndex = 4;
            allbookpanel.Paint += this.allbookpanel_Paint;
            // 
            // addpanel
            // 
            addpanel.BackColor = Color.MistyRose;
            addpanel.Controls.Add(label5);
            addpanel.Controls.Add(button4);
            addpanel.Controls.Add(textBox3);
            addpanel.Controls.Add(textBox2);
            addpanel.Controls.Add(textBox1);
            addpanel.Controls.Add(label7);
            addpanel.Controls.Add(label6);
            addpanel.Controls.Add(label4);
            addpanel.Location = new Point(277, 3);
            addpanel.Name = "addpanel";
            addpanel.Size = new Size(696, 496);
            addpanel.TabIndex = 7;
            addpanel.Visible = false;
            addpanel.Paint += this.addpanel_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(249, 17);
            label2.Name = "label2";
            label2.Size = new Size(201, 41);
            label2.TabIndex = 5;
            label2.Text = "All Books";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += this.label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 394);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 106);
            label4.Name = "label4";
            label4.Size = new Size(162, 39);
            label4.TabIndex = 0;
            label4.Text = "Book Title";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += this.label4_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(91, 169);
            label7.Name = "label7";
            label7.Size = new Size(162, 39);
            label7.TabIndex = 3;
            label7.Text = "Author";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += this.label7_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(259, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 30);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(259, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 30);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.FlatAppearance.BorderColor = Color.SpringGreen;
            button4.FlatAppearance.MouseOverBackColor = Color.MediumSpringGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(259, 320);
            button4.Name = "button4";
            button4.Size = new Size(133, 40);
            button4.TabIndex = 5;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += this.button4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(195, 17);
            label5.Name = "label5";
            label5.Size = new Size(255, 68);
            label5.TabIndex = 5;
            label5.Text = "Add Book";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += this.label5_Click;
            // 
            // deletepanel
            // 
            deletepanel.BackColor = Color.MistyRose;
            deletepanel.Controls.Add(textBox7);
            deletepanel.Controls.Add(label12);
            deletepanel.Controls.Add(textBox4);
            deletepanel.Controls.Add(textBox6);
            deletepanel.Controls.Add(label9);
            deletepanel.Controls.Add(label11);
            deletepanel.Controls.Add(label8);
            deletepanel.Controls.Add(button7);
            deletepanel.ForeColor = SystemColors.ControlText;
            deletepanel.Location = new Point(280, 85);
            deletepanel.Name = "deletepanel";
            deletepanel.Size = new Size(696, 496);
            deletepanel.TabIndex = 8;
            deletepanel.Visible = false;
            deletepanel.Paint += this.deletepanel_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.Tomato;
            button7.FlatAppearance.BorderColor = Color.Tomato;
            button7.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(285, 319);
            button7.Name = "button7";
            button7.Size = new Size(133, 40);
            button7.TabIndex = 5;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            button7.Click += this.button7_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(91, 242);
            label6.Name = "label6";
            label6.Size = new Size(162, 39);
            label6.TabIndex = 2;
            label6.Text = "Quantity";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += this.label6_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(259, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 30);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(229, 35);
            label8.Name = "label8";
            label8.Size = new Size(255, 68);
            label8.TabIndex = 5;
            label8.Text = "Delete Book";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += this.label8_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(272, 138);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(320, 30);
            textBox7.TabIndex = 18;
            textBox7.TextChanged += this.textBox7_TextChanged;
            // 
            // label12
            // 
            label12.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(104, 132);
            label12.Name = "label12";
            label12.Size = new Size(162, 39);
            label12.TabIndex = 17;
            label12.Text = "Book Id";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += this.label12_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(272, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 30);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(272, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(320, 30);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += this.textBox6_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(104, 252);
            label9.Name = "label9";
            label9.Size = new Size(162, 39);
            label9.TabIndex = 13;
            label9.Text = "Author";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += this.label9_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(104, 189);
            label11.Name = "label11";
            label11.Size = new Size(162, 39);
            label11.TabIndex = 11;
            label11.Text = "Book Title";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += this.label11_Click;
            // 
            // issuedpanel
            // 
            issuedpanel.BackColor = Color.MistyRose;
            issuedpanel.Controls.Add(dateTimePicker2);
            issuedpanel.Controls.Add(label16);
            issuedpanel.Controls.Add(dateTimePicker1);
            issuedpanel.Controls.Add(label14);
            issuedpanel.Controls.Add(textBox8);
            issuedpanel.Controls.Add(label13);
            issuedpanel.Controls.Add(textBox5);
            issuedpanel.Controls.Add(label10);
            issuedpanel.Controls.Add(dataGridView2);
            issuedpanel.Controls.Add(label15);
            issuedpanel.ForeColor = SystemColors.ControlText;
            issuedpanel.Location = new Point(280, 3);
            issuedpanel.Name = "issuedpanel";
            issuedpanel.Size = new Size(696, 496);
            issuedpanel.TabIndex = 19;
            issuedpanel.Visible = false;
            issuedpanel.Paint += this.issuedpanel_Paint;
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(172, -1);
            label15.Name = "label15";
            label15.Size = new Size(255, 68);
            label15.TabIndex = 5;
            label15.Text = "Issued Books";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += this.label15_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(50, 308);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(626, 178);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += this.dataGridView2_CellContentClick;
            // 
            // label10
            // 
            label10.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(91, 70);
            label10.Name = "label10";
            label10.Size = new Size(162, 39);
            label10.TabIndex = 18;
            label10.Text = "Book Id";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += this.label10_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(291, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(320, 30);
            textBox5.TabIndex = 19;
            textBox5.TextChanged += this.textBox5_TextChanged;
            // 
            // label13
            // 
            label13.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(91, 132);
            label13.Name = "label13";
            label13.Size = new Size(162, 39);
            label13.TabIndex = 20;
            label13.Text = "Book Id";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += this.label13_Click;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(291, 135);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(320, 30);
            textBox8.TabIndex = 21;
            textBox8.TextChanged += this.textBox8_TextChanged;
            // 
            // label14
            // 
            label14.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(91, 195);
            label14.Name = "label14";
            label14.Size = new Size(162, 39);
            label14.TabIndex = 22;
            label14.Text = "Issued Date";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += this.label14_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(291, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 23);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.Value = new DateTime(2025, 7, 21, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += this.dateTimePicker1_ValueChanged;
            // 
            // label16
            // 
            label16.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(91, 248);
            label16.Name = "label16";
            label16.Size = new Size(162, 39);
            label16.TabIndex = 24;
            label16.Text = "Return date";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Click += this.label16_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(291, 256);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(320, 23);
            dateTimePicker2.TabIndex = 25;
            dateTimePicker2.Value = new DateTime(2025, 7, 21, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += this.dateTimePicker2_ValueChanged;
            // 
            // BooksManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 647);
            Controls.Add(allbookpanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksManagement";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            allbookpanel.ResumeLayout(false);
            addpanel.ResumeLayout(false);
            addpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            deletepanel.ResumeLayout(false);
            deletepanel.PerformLayout();
            issuedpanel.ResumeLayout(false);
            issuedpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label3;
        private Button button6;
        private Panel allbookpanel;
        private Panel addpanel;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label7;
        private Panel deletepanel;
        private Button button7;
        private Label label5;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Panel issuedpanel;
        private Label label15;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label9;
        private Label label11;
        private Label label8;
        private Label label13;
        private TextBox textBox5;
        private Label label10;
        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private TextBox textBox8;
    }
}