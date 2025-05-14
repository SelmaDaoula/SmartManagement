using SmartManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartManagement.Services
{
    internal class ProductService
    {
        public List<dynamic> GetAllProduits()
        {
            using (var context = new AppDbContext())
            {
                return context.Produits
                              .Include(p => p.Categorie)
                              .Select(p => new
                              {
                                  p.Id,
                                  p.Nom,
                                  p.QuantiteStock,
                                  p.PrixUnitaire,
                                  Categorie = p.Categorie.Nom,
                                  p.SeuilAlerte
                              })
                              .ToList<dynamic>();
            }
        }

        public void AddProduct(Product newProduct)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(new Categorie { Id = newProduct.CategorieId }).State = EntityState.Unchanged;
                context.Produits.Add(newProduct); // No need to set Id, EF will auto-increment it.
                context.SaveChanges();
            }
        }


        public void UpdateProduct(Product updatedProduct)
        {
            using (var context = new AppDbContext())
            {
                var existingProduct = context.Produits.Find(updatedProduct.Id);
                if (existingProduct != null)
                {
                    existingProduct.Nom = updatedProduct.Nom;
                    existingProduct.QuantiteStock = updatedProduct.QuantiteStock;
                    existingProduct.PrixUnitaire = updatedProduct.PrixUnitaire;
                    existingProduct.CategorieId = updatedProduct.CategorieId;
                    existingProduct.SeuilAlerte = updatedProduct.SeuilAlerte;

                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produit non trouvé.");
                }
            }
        }
        public void DeleteProduct(int productId)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Produits.Find(productId);
                if (product != null)
                {
                    context.Produits.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produit non trouvé.");
                }
            }
        }

    }

}
