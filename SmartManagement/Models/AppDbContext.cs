using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace SmartManagement.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Chemin relatif vers la DB dans le dossier Models/
            var dbPath = Path.Combine("Models", "smartmanagement.db");

            // Affiche le chemin absolu pour débogage (à supprimer en production)
            Console.WriteLine($"Chemin de la base de données : {Path.GetFullPath(dbPath)}");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration supplémentaire des modèles si nécessaire
            // Exemple : Définir des relations ou contraintes
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId);
        }
    }
}