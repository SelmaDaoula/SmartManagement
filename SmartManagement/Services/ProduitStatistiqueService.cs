using System;
using System.Collections.Generic;
using System.Linq;
using SmartManagement.Models;

namespace SmartManagement.Services
{
    internal class ProduitStatistiqueService
    {
        private List<MouvementStock> _mouvementsStock;

        public ProduitStatistiqueService(List<MouvementStock> mouvementsStock)
        {
            _mouvementsStock = mouvementsStock;
        }

        // Méthode pour récupérer les produits les plus vendus aujourd'hui
        public ProduitStatistique GetProduitLePlusVenduAujourdHui()
        {
            var aujourdHui = DateTime.Today;
            var produitsVendusAujourdHui = _mouvementsStock
                .Where(m => m.Date.Date == aujourdHui)
                .GroupBy(m => m.ProduitId)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.First().Produit.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .FirstOrDefault();

            return produitsVendusAujourdHui;
        }

        // Méthode pour récupérer les produits les plus vendus cette semaine
        public ProduitStatistique GetProduitLePlusVenduCetteSemaine()
        {
            var today = DateTime.Today;
            var debutSemaine = today.AddDays(-(int)today.DayOfWeek);
            var produitsVendusCetteSemaine = _mouvementsStock
                .Where(m => m.Date >= debutSemaine)
                .GroupBy(m => m.ProduitId)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.First().Produit.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .FirstOrDefault();

            return produitsVendusCetteSemaine;
        }

        // Méthode pour récupérer les produits les plus vendus le mois dernier
        public ProduitStatistique GetProduitLePlusVenduMoisDernier()
        {
            var today = DateTime.Today;
            var debutMoisDernier = new DateTime(today.Year, today.Month - 1, 1);
            var finMoisDernier = debutMoisDernier.AddMonths(1).AddDays(-1);
            var produitsVendusMoisDernier = _mouvementsStock
                .Where(m => m.Date >= debutMoisDernier && m.Date <= finMoisDernier)
                .GroupBy(m => m.ProduitId)
                .Select(g => new ProduitStatistique
                {
                    ProduitNom = g.First().Produit.Nom,
                    QuantiteVendue = g.Sum(m => m.Quantite)
                })
                .OrderByDescending(p => p.QuantiteVendue)
                .FirstOrDefault();

            return produitsVendusMoisDernier;
        }
    }
}
