namespace SmartManagement.Views
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new TextBox();
            txtMotDePasse = new TextBox();
            btnLogin = new Button();
            lblLogin = new Label();
            lblMotDePasse = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            CreateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(170, 268);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 27);
            txtLogin.TabIndex = 0;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(170, 315);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.Size = new Size(200, 27);
            txtMotDePasse.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 181, 35);
            btnLogin.Location = new Point(65, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(211, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Se Connecter";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(31, 271);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(43, 20);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "login";
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(31, 318);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(70, 20);
            lblMotDePasse.TabIndex = 4;
            lblMotDePasse.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 208);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 6;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 88, 135);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(402, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 538);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 356);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 445);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 8;
            label2.Text = "Don't have an account yet? ";
            // 
            // CreateAccount
            // 
            CreateAccount.BackColor = Color.Transparent;
            CreateAccount.FlatAppearance.BorderSize = 0;
            CreateAccount.FlatStyle = FlatStyle.Flat;
            CreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CreateAccount.ForeColor = Color.FromArgb(231, 76, 60);
            CreateAccount.Location = new Point(206, 441);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(94, 29);
            CreateAccount.TabIndex = 9;
            CreateAccount.Text = "Create one now!";
            CreateAccount.UseVisualStyleBackColor = false;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(769, 535);
            Controls.Add(CreateAccount);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblMotDePasse);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMotDePasse;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private System.Windows.Forms.Button CreateAccount;
        private PictureBox pictureBox2;
    }
}
