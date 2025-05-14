using System;
using System.Windows.Forms;
using SmartManagement.Controllers;
using SmartManagement.Services;

namespace SmartManagement.Views
{
    public partial class LoginForm : Form
    {
        private UserController _userController;

        public LoginForm()
        {
            InitializeComponent();

            // Création de l'instance d'AuthService
            AuthService authService = new AuthService();

            // Passer l'instance authService au constructeur de UserController
            _userController = new UserController(authService);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string motDePasse = txtMotDePasse.Text;

            try
            {
                var user = _userController.AuthenticateUser(login, motDePasse);
                MainForm mainForm = new MainForm(user);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                // Affiche le message spécifique (login ou mot de passe incorrect)
                MessageBox.Show(ex.Message, "Erreur d'authentification",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Efface seulement le mot de passe si c'est lui qui est incorrect
                if (ex.Message == "Mot de passe incorrect")
                {
                    txtMotDePasse.Text = "";
                    txtMotDePasse.Focus();
                }
                else if (ex.Message == "Login incorrect")
                {
                    // Efface les deux champs si le login est incorrect
                    txtLogin.Text = "";
                    txtMotDePasse.Text = "";
                    txtLogin.Focus();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ferme l'application si LoginForm est fermé
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            // Crée une instance de CreateAccountForm
            CreateAccountForm createAccountForm = new CreateAccountForm();

            // Cache le LoginForm actuel
            this.Hide();

            // Ouvre CreateAccountForm en mode dialogue (bloque LoginForm)
            createAccountForm.ShowDialog();

            // Réaffiche LoginForm après fermeture de CreateAccountForm
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
