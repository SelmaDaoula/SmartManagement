using System;
using System.Windows.Forms;
using SmartManagement.Controllers;
using SmartManagement.Models;

namespace SmartManagement.Views
{
    public partial class CategoryForm : Form
    {
        private readonly CategorieController _controller;

        public CategoryForm()
        {
            InitializeComponent();
            _controller = new CategorieController();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dataGridViewCategories.DataSource = _controller.GetAllCategories();

            // Empêche le plantage si la colonne "Produits" n'existe pas
            if (dataGridViewCategories.Columns["Produits"] != null)
            {
                dataGridViewCategories.Columns["Produits"].Visible = false;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNom.Text))
            {
                var nouvelleCategorie = new Categorie { Nom = txtNom.Text };
                _controller.AddCategorie(nouvelleCategorie);
                LoadCategories();
                txtNom.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie.");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.CurrentRow?.DataBoundItem is Categorie categorie && !string.IsNullOrWhiteSpace(txtNom.Text))
            {
                categorie.Nom = txtNom.Text;
                _controller.UpdateCategorie(categorie);
                LoadCategories();
                txtNom.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie et entrer un nouveau nom.");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.CurrentRow?.DataBoundItem is Categorie categorie)
            {
                var confirmResult = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer la catégorie '{categorie.Nom}' ?",
                    "Confirmation", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    _controller.DeleteCategorie(categorie.Id);
                    LoadCategories();
                    txtNom.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
            }
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategories.CurrentRow?.DataBoundItem is Categorie categorie)
            {
                txtNom.Text = categorie.Nom;
            }
        }
    }
}
