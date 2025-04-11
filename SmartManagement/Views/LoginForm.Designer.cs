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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblLogin.Size = new Size(123, 20);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Nom d'utilisateur";
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(31, 318);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(98, 20);
            lblMotDePasse.TabIndex = 4;
            lblMotDePasse.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 124);
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
            panel1.Location = new Point(402, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 538);
            panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            ClientSize = new Size(769, 535);
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
    }
}
