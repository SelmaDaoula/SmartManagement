using System;
using System.Linq;
using System.Windows.Forms;
using SmartManagement.Models;
using SmartManagement.Services;

namespace SmartManagement.Views
{
    public partial class MouvementStockForm : Form
    {
        private readonly MouvementStockService _service;
        private readonly AppDbContext _context;

        public MouvementStockForm()
        {
            InitializeComponent();
            _context = new AppDbContext(); // Assure-toi que AppDbContext est bien configuré
            CategorieService categorieService = new CategorieService(); // Création d'une instance de CategorieService si nécessaire
            _service = new MouvementStockService(_context, categorieService); // Passage des deux paramètres
        }

        private void MouvementStockForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbProduits.DataSource = _context.Produits.ToList(); // Charger la liste des produits
                cbProduits.DisplayMember = "Nom"; // Afficher le nom du produit
                cbProduits.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

                cbTypeMouvement.Items.AddRange(new string[] { "Entrée", "Sortie" });
                cbTypeMouvement.SelectedIndex = 0; // Par défaut, sélectionne "Entrée"

                LoadMouvements();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}");
            }
        }

        private void LoadMouvements()
        {
            try
            {
                var mouvements = _service.GetAllMouvements();
                dataGridViewMouvements.DataSource = mouvements;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des mouvements : {ex.Message}");
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cbTypeMouvement.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Veuillez sélectionner un type de mouvement.");
                    return;
                }

                if (!int.TryParse(txtQuantite.Text, out int quantite) || quantite <= 0)
                {
                    MessageBox.Show("Veuillez entrer une quantité valide.");
                    return;
                }

                if (cbProduits.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un produit.");
                    return;
                }

                int produitId = (int)cbProduits.SelectedValue;
                _service.AddMouvement(type, quantite, produitId);

                LoadMouvements();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }
    }
}
