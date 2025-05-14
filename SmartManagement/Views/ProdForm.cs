using SmartManagement.Controllers;
using SmartManagement.Models;
using SmartManagement.Services;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SmartManagement.Views
{
    public partial class ProdForm : Form
    {
        private ProductController _productController;
        private CategorieController _categorieController;

        public ProdForm()
        {
            InitializeComponent();
            _productController = new ProductController();
            _categorieController = new CategorieController();
            LoadCategories();
        }

        private void ProdForm_Load(object sender, EventArgs e)
        {
            LoadProducts();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "ID",
                ReadOnly = true,
                Width = 125
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                DataPropertyName = "Nom",
                Name = "Nom",
                ReadOnly = true,
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantité en stock",
                DataPropertyName = "QuantiteStock",
                Name = "QuantiteStock",
                ReadOnly = true,
                Width = 125
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Prix Unitaire",
                DataPropertyName = "PrixUnitaire",
                Name = "PrixUnitaire",
                ReadOnly = true,
                Width = 125
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Catégorie",
                DataPropertyName = "Categorie",
                Name = "Categorie",
                ReadOnly = true,
                Width = 125
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Seuil d’Alerte",
                DataPropertyName = "SeuilAlerte",
                Name = "SeuilAlerte",
                ReadOnly = true,
                Width = 125
            });

            // 🔁 Abonner à l'événement
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadProducts()
        {
            try
            {
                var produits = _productController.GetAllProduits();
                dataGridView1.DataSource = produits;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            var categoryNames = _categorieController.GetCategoryNames();

            if (categoryNames == null || categoryNames.Count == 0)
            {
                MessageBox.Show("Aucune catégorie trouvée.");
                return;
            }

            ProductCategoryBox.Items.Clear();

            foreach (var name in categoryNames)
            {
                ProductCategoryBox.Items.Add(name);
            }

            ProductCategoryBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryName = ProductCategoryBox.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("❌ Veuillez sélectionner une catégorie.");
                    return;
                }

                int categoryId = _categorieController.GetCategoryIdByName(categoryName);

                if (categoryId == 0)
                {
                    MessageBox.Show("❌ Catégorie invalide.");
                    return;
                }

                Product newProduct = new Product
                {
                    Nom = ProductName.Text,
                    QuantiteStock = int.Parse(ProductQuantity.Text),
                    PrixUnitaire = decimal.Parse(ProductPrice.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                    CategorieId = categoryId,
                    SeuilAlerte = int.Parse(ProductIAlertSeuil.Text)
                };

                _productController.AddProduct(newProduct);
                MessageBox.Show("✅ Produit ajouté !");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erreur : " + ex.Message);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(ProductId.Text, out int productId))
                {
                    MessageBox.Show("❌ L'identifiant du produit est invalide.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ProductName.Text))
                {
                    MessageBox.Show("❌ Le nom du produit ne peut pas être vide.");
                    return;
                }

                if (!int.TryParse(ProductQuantity.Text, out int quantite))
                {
                    MessageBox.Show("❌ La quantité doit être un nombre entier.");
                    return;
                }

                if (!decimal.TryParse(ProductPrice.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal prix))
                {
                    MessageBox.Show("❌ Le prix doit être un nombre décimal.");
                    return;
                }

                var categoryName = ProductCategoryBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("❌ Veuillez sélectionner une catégorie.");
                    return;
                }

                int categorieId = _categorieController.GetCategoryIdByName(categoryName);

                if (categorieId == 0)
                {
                    MessageBox.Show("❌ Catégorie invalide.");
                    return;
                }

                if (!int.TryParse(ProductIAlertSeuil.Text, out int seuil))
                {
                    MessageBox.Show("❌ Le seuil d’alerte doit être un nombre entier.");
                    return;
                }

                Product updatedProduct = new Product
                {
                    Id = productId,
                    Nom = ProductName.Text,
                    QuantiteStock = quantite,
                    PrixUnitaire = prix,
                    CategorieId = categorieId,
                    SeuilAlerte = seuil
                };

                _productController.UpdateProduct(updatedProduct);

                MessageBox.Show("✅ Produit modifié avec succès !");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erreur : " + ex.Message + "\n\nTrace : " + ex.StackTrace);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _productController.DeleteProduct(selectedProductId);
                        MessageBox.Show("Produit supprimé avec succès !");
                        LoadProducts(); // Recharge la liste des produits
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.");
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                ProductId.Text = row.Cells["ID"].Value?.ToString() ?? "";
                ProductName.Text = row.Cells["Nom"].Value?.ToString() ?? "";
                ProductQuantity.Text = row.Cells["QuantiteStock"].Value?.ToString() ?? "";
                ProductPrice.Text = row.Cells["PrixUnitaire"].Value?.ToString() ?? "";
                ProductIAlertSeuil.Text = row.Cells["SeuilAlerte"].Value?.ToString() ?? "";

                string categoryName = row.Cells["Categorie"].Value?.ToString() ?? "";
                ProductCategoryBox.SelectedItem = categoryName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Utilisé si tu veux gérer des clics dans des colonnes spécifiques
        }
    }
}
