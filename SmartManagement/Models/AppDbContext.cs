using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace SmartManagement.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<MouvementStock> MouvementsStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 🔄 Chemin relatif depuis le répertoire d'exécution (bin/Debug/...)
            var relativePath = Path.Combine("..", "..", "..", "Models", "smartmanagement.db");

            // 🧼 Convertir en chemin absolu propre
            var dbPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, relativePath));

            // 🐞 Affiche le chemin utilisé pour déboguer
            Console.WriteLine($"📁 Chemin de la base de données : {dbPath}");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Categorie)
                .WithMany(c => c.Produits)
                .HasForeignKey(p => p.CategorieId);

            modelBuilder.Entity<MouvementStock>()
                .HasOne(m => m.Produit)
                .WithMany()
                .HasForeignKey(m => m.ProduitId);
        }
    }
}
