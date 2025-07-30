namespace Library_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            button1 = new Button();
            error = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 63);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = SystemColors.HighlightText;
            usernametxt.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.ForeColor = SystemColors.Desktop;
            usernametxt.Location = new Point(15, 101);
            usernametxt.Name = "usernametxt";
            usernametxt.PlaceholderText = "Enter UserName";
            usernametxt.Size = new Size(353, 34);
            usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordtxt.BackColor = SystemColors.HighlightText;
            passwordtxt.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.ForeColor = SystemColors.Desktop;
            passwordtxt.Location = new Point(15, 180);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Enter Password";
            passwordtxt.Size = new Size(353, 34);
            passwordtxt.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button1.FlatAppearance.MouseOverBackColor = Color.Pink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(114, 254);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = Color.Transparent;
            error.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            error.ForeColor = Color.Red;
            error.Location = new Point(31, 323);
            error.Name = "error";
            error.Size = new Size(71, 18);
            error.TabIndex = 5;
            error.Text = "ertyuiop";
            // 
            // label2
            // 
            label2.BackColor = Color.Sienna;
            label2.Font = new Font("Book Antiqua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(217, 97);
            label2.Name = "label2";
            label2.Size = new Size(373, 62);
            label2.TabIndex = 6;
            label2.Text = "Central Public Library";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(error);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(32, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 377);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(92, 34);
            label3.Name = "label3";
            label3.Size = new Size(203, 36);
            label3.TabIndex = 8;
            label3.Text = "Login Form";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 638);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Button button1;
        private Label error;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}