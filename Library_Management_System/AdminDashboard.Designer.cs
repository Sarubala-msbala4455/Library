namespace Library_Management_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            button5 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            adminid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(248, 20);
            label1.Name = "label1";
            label1.Size = new Size(373, 42);
            label1.TabIndex = 2;
            label1.Text = "Central Public Library";
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 613);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 25);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(379, 43);
            label2.TabIndex = 3;
            label2.Text = "Welcome Admin!!!!";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 526);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(3, 46);
            button2.Name = "button2";
            button2.Size = new Size(252, 48);
            button2.TabIndex = 9;
            button2.Text = "Add Admins";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Green;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(42, 232);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.SaddleBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(147, 232);
            button1.Name = "button1";
            button1.Size = new Size(223, 120);
            button1.TabIndex = 7;
            button1.Text = "Members Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Green;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.FlatAppearance.BorderColor = Color.Green;
            button4.FlatAppearance.MouseOverBackColor = Color.SaddleBrown;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.HighlightText;
            button4.Location = new Point(147, 74);
            button4.Name = "button4";
            button4.Size = new Size(223, 122);
            button4.TabIndex = 3;
            button4.Text = "Books    Management";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.Tomato;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(115, 408);
            button3.Name = "button3";
            button3.Size = new Size(141, 48);
            button3.TabIndex = 2;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(adminid);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(427, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(414, 406);
            panel4.TabIndex = 10;
            panel4.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SaddleBrown;
            button5.FlatAppearance.BorderColor = Color.SaddleBrown;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.HighlightText;
            button5.Location = new Point(136, 339);
            button5.Name = "button5";
            button5.Size = new Size(125, 35);
            button5.TabIndex = 11;
            button5.Text = "Add ";
            button5.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 197);
            label7.Name = "label7";
            label7.Size = new Size(116, 30);
            label7.TabIndex = 10;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(154, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 30);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // label6
            // 
            label6.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 253);
            label6.Name = "label6";
            label6.Size = new Size(128, 63);
            label6.TabIndex = 8;
            label6.Text = "Phone Number";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // label5
            // 
            label5.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 141);
            label5.Name = "label5";
            label5.Size = new Size(116, 30);
            label5.TabIndex = 7;
            label5.Text = "UserName";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(154, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 30);
            textBox3.TabIndex = 6;
            textBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(154, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 30);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // adminid
            // 
            adminid.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminid.Location = new Point(154, 80);
            adminid.Name = "adminid";
            adminid.Size = new Size(249, 30);
            adminid.TabIndex = 4;
            adminid.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 78);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 1;
            label4.Text = "Admin Id";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 20);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 0;
            label3.Text = "Add Admin";
            label3.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Location = new Point(417, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(440, 386);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 638);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox adminid;
        private Label label4;
        private Label label3;
        private Button button5;
        private Label label7;
        private TextBox textBox4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}