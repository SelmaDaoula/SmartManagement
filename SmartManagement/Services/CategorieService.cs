using SmartManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartManagement.Services
{
    public class CategorieService
    {
        // Obtenir toutes les catégories
        public List<Categorie> GetAllCategories()
        {
            using (var context = new AppDbContext())
            {
                return context.Categories.ToList();
            }
        }

        // Ajouter une catégorie
        public void AddCategorie(Categorie categorie)
        {
            using (var context = new AppDbContext())
            {
                context.Categories.Add(categorie);  // Pas besoin de définir l'ID, EF le fera automatiquement.
                context.SaveChanges();
            }
        }

        // Mettre à jour une catégorie
        public void UpdateCategorie(Categorie updatedCategorie)
        {
            using (var context = new AppDbContext())
            {
                var existingCategory = context.Categories.Find(updatedCategorie.Id);
                if (existingCategory != null)
                {
                    existingCategory.Nom = updatedCategorie.Nom;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Catégorie non trouvée.");
                }
            }
        }

        // Supprimer une catégorie
        public void DeleteCategorie(int categorieId)
        {
            using (var context = new AppDbContext())
            {
                var category = context.Categories.Find(categorieId);
                if (category != null)
                {
                    context.Categories.Remove(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Catégorie non trouvée.");
                }
            }
        }

        // Obtenir l'ID d'une catégorie par son nom
        public int GetCategoryIdByName(string name)
        {
            using (var context = new AppDbContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.Nom == name);
                return category?.Id ?? -1;  // Retourne l'ID ou -1 si non trouvé
            }
        }

        // Obtenir une catégorie par son nom
        public Categorie GetCategoryByName(string name)
        {
            using (var context = new AppDbContext())
            {
                return context.Categories.FirstOrDefault(c => c.Nom == name);
            }
        }

        // Obtenir les noms de toutes les catégories
        public List<string> GetCategoryNames()
        {
            using (var context = new AppDbContext())
            {
                return context.Categories.Select(c => c.Nom).ToList();
            }
        }
    }
}
