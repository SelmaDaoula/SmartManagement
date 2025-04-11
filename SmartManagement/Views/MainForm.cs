using System;
using System.Windows.Forms;
using SmartManagement.Models;

namespace SmartManagement.Views
{
    public partial class MainForm : Form
    {
        private User _user;

        // Constructeur qui prend un objet User en paramètre
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Vérifier si l'utilisateur est null
            if (_user == null)
            {
                MessageBox.Show("L'utilisateur est null.");
                return;
            }

            // Afficher les informations de l'utilisateur dans l'interface
            lblUserName.Text = $"Bienvenue, {_user.Nom}";

            // Vérifier si le rôle de l'utilisateur est null
            if (_user.Role == null)
            {
                lblRole.Text = "Rôle : Aucun rôle attribué";
            }
            else
            {
                lblRole.Text = $"Rôle : {_user.Role.Nom}";
            }
        }
    }
}
