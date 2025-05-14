using System;
using System.Collections.Generic;
using System.Linq;
using SmartManagement.Models;
using SmartManagement.Services;

namespace SmartManagement.Controllers
{
    internal class ProduitStatistiqueController
    {
        private readonly ProduitStatistiqueService _service;

        public ProduitStatistiqueController(List<MouvementStock> mouvementsStock)
        {
            // Initialisation du service avec les données de mouvements de stock
            _service = new ProduitStatistiqueService(mouvementsStock);
        }

        public void AfficherProduitLePlusVenduAujourdHui()
        {
            var produitAujourdHui = _service.GetProduitLePlusVenduAujourdHui();
            if (produitAujourdHui != null)
                Console.WriteLine($"Produit le plus vendu aujourd'hui : {produitAujourdHui.ProduitNom} avec {produitAujourdHui.QuantiteVendue} ventes.");
            else
                Console.WriteLine("Aucun produit vendu aujourd'hui.");
        }

        public void AfficherProduitLePlusVenduCetteSemaine()
        {
            var produitSemaine = _service.GetProduitLePlusVenduCetteSemaine();
            if (produitSemaine != null)
                Console.WriteLine($"Produit le plus vendu cette semaine : {produitSemaine.ProduitNom} avec {produitSemaine.QuantiteVendue} ventes.");
            else
                Console.WriteLine("Aucun produit vendu cette semaine.");
        }

        public void AfficherProduitLePlusVenduMoisDernier()
        {
            var produitMoisDernier = _service.GetProduitLePlusVenduMoisDernier();
            if (produitMoisDernier != null)
                Console.WriteLine($"Produit le plus vendu le mois dernier : {produitMoisDernier.ProduitNom} avec {produitMoisDernier.QuantiteVendue} ventes.");
            else
                Console.WriteLine("Aucun produit vendu le mois dernier.");
        }
    }
}
