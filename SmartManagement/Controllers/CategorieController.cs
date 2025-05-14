using SmartManagement.Models;
using SmartManagement.Services;
using System;
using System.Collections.Generic;
using SmartManagement.Models;  // Ajoute ce using si Categorie est dans ce namespace


namespace SmartManagement.Controllers
{
    public class CategorieController
    {
        private readonly CategorieService _categorieService;

        public CategorieController()
        {
            _categorieService = new CategorieService();
        }

        // Méthode pour obtenir toutes les catégories
        public List<Categorie> GetAllCategories()
        {
            return _categorieService.GetAllCategories();
        }

        // Méthode pour ajouter une catégorie
        public void AddCategorie(Categorie newCategorie)
        {
            ValidateCategorie(newCategorie);
            _categorieService.AddCategorie(newCategorie);
        }

        // Méthode pour mettre à jour une catégorie
        public void UpdateCategorie(Categorie updatedCategorie)
        {
            ValidateCategorie(updatedCategorie);
            _categorieService.UpdateCategorie(updatedCategorie);
        }

        // Méthode pour supprimer une catégorie
        public void DeleteCategorie(int categorieId)
        {
            if (categorieId <= 0)
                throw new ArgumentException("ID de catégorie invalide.");

            _categorieService.DeleteCategorie(categorieId);
        }

        // Méthode pour valider les données d'une catégorie
        private void ValidateCategorie(Categorie categorie)
        {
            if (categorie == null)
                throw new ArgumentNullException(nameof(categorie));

            if (string.IsNullOrWhiteSpace(categorie.Nom))
                throw new ArgumentException("Le nom de la catégorie ne peut pas être vide.");
        }

        // Méthode pour obtenir l'ID d'une catégorie par son nom
        // Méthode pour obtenir l'ID d'une catégorie par son nom
        public int GetCategoryIdByName(string name)
        {
            var categorie = _categorieService.GetCategoryByName(name); // Utilisation du service pour la récupération de la catégorie
            return categorie?.Id ?? -1; // Retourne l'ID ou -1 si non trouvé
        }


        public List<string> GetCategoryNames()
        {
            return _categorieService.GetCategoryNames();
        }

    }
}
