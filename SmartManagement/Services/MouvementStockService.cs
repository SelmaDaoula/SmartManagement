using SmartManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartManagement.Services
{
    public class MouvementStockService
    {
        private readonly AppDbContext _context;
        private readonly CategorieService _categorieService;

        public MouvementStockService(AppDbContext context, CategorieService categorieService)
        {
            _context = context;
            _categorieService = categorieService;
        }

        public void AddMouvement(string type, int quantite, int produitId)
        {
            // Récupérer le produit
            var produit = _context.Produits.Include(p => p.Categorie).FirstOrDefault(p => p.Id == produitId);
            if (produit == null)
                throw new Exception("Produit introuvable");

            // Vérification de la catégorie associée au produit
            if (produit.Categorie == null)
                throw new Exception("La catégorie du produit est introuvable");

            // Exemple d'utilisation de CategorieService pour obtenir la catégorie
            var categorie = _categorieService.GetCategoryByName(produit.Categorie.Nom);
            if (categorie == null)
                throw new Exception("Catégorie introuvable");

            // Création du mouvement
            var mouvement = new MouvementStock
            {
                TypeMouvement = type,
                Quantite = quantite,
                Date = DateTime.Now,
                ProduitId = produitId,
                Produit = produit
            };

            // Mise à jour du stock en fonction du type de mouvement
            if (type == "Entrée")
            {
                produit.QuantiteStock += quantite; // Entrée dans le stock
            }
            else if (type == "Sortie")
            {
                if (produit.QuantiteStock < quantite)
                    throw new Exception("Stock insuffisant"); // Vérification du stock pour la sortie

                produit.QuantiteStock -= quantite; // Sortie du stock
            }
            else
            {
                throw new Exception("Type de mouvement invalide");
            }

            // Ajouter le mouvement et sauvegarder les changements
            _context.MouvementsStock.Add(mouvement);
            _context.SaveChanges();
        }

        public List<MouvementStock> GetAllMouvements()
        {
            // Récupérer tous les mouvements avec les produits associés
            return _context.MouvementsStock.Include(m => m.Produit).ThenInclude(p => p.Categorie).ToList();
        }
        public List<ProduitStatistique> GetTopProduitAujourdhui()
        {
            var today = DateTime.Today;

            // Filtrer les mouvements de type "Sortie" (ventes) pour aujourd'hui
            var mouvementsAujourdhui = _context.MouvementsStock
                .Where(m => m.TypeMouvement == "Sortie" && m.Date.Date == today)
                .GroupBy(m => m.Produit)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.Key.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .ToList();

            return mouvementsAujourdhui;
        }
        public List<ProduitStatistique> GetTopProduitSemaine()
        {
            var startOfWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek); // Premier jour de la semaine (dimanche)
            var endOfWeek = startOfWeek.AddDays(7); // Dernier jour de la semaine (samedi)

            var mouvementsSemaine = _context.MouvementsStock
                .Where(m => m.TypeMouvement == "Sortie" && m.Date >= startOfWeek && m.Date < endOfWeek)
                .GroupBy(m => m.Produit)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.Key.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .ToList();

            return mouvementsSemaine;
        }
        public List<ProduitStatistique> GetTopProduitMoisDernier()
        {
            var firstDayOfLastMonth = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            var lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1); // Dernier jour du mois précédent

            var mouvementsMoisDernier = _context.MouvementsStock
                .Where(m => m.TypeMouvement == "Sortie" && m.Date >= firstDayOfLastMonth && m.Date <= lastDayOfLastMonth)
                .GroupBy(m => m.Produit)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.Key.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .ToList();

            return mouvementsMoisDernier;
        }


    }
}
