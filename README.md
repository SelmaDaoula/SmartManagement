# 📦 SmartManagement - Application de Gestion de Stock

Application de bureau développée en C# permettant la gestion complète du stock d'un magasin avec authentification, suivi des produits et mise à jour d'inventaire en temps réel.

## 📋 Table des matières

- [Aperçu](#aperçu)
- [Fonctionnalités](#fonctionnalités)
- [Technologies](#technologies)
- [Architecture](#architecture)
- [Prérequis](#prérequis)
- [Installation](#installation)
- [Utilisation](#utilisation)
- [Structure du projet](#structure-du-projet)
- [Base de données](#base-de-données)

## 👀 Aperçu

SmartManagement est une solution complète de gestion de stock pour les commerces et magasins. L'application offre une interface utilisateur intuitive permettant de gérer efficacement l'inventaire, suivre les produits et consulter les statistiques en temps réel.

## ✨ Fonctionnalités

### 🔐 Authentification
- Système de login sécurisé
- Gestion des sessions utilisateur
- Contrôle d'accès basé sur les rôles

### 📊 Gestion des Produits
- **Ajouter** de nouveaux produits avec détails complets
- **Modifier** les informations existantes
- **Supprimer** des produits obsolètes
- **Consulter** le catalogue complet avec recherche et filtres

### 📦 Gestion du Stock
- Suivi en temps réel des quantités disponibles
- Mise à jour automatique lors des opérations
- Alertes pour stock faible
- Historique des mouvements de stock

### 📈 Tableaux de bord
- Visualisation des statistiques d'inventaire
- Rapports sur les produits en rupture
- Analyse des tendances de stock

### 🔍 Recherche et Filtres
- Recherche rapide par nom, catégorie ou code produit
- Filtres avancés pour affiner les résultats
- Tri personnalisable des données

## 🚀 Technologies

### Langage & Framework
- **C#** - Langage de programmation principal
- **.NET Framework** / **.NET Core** - Framework de développement

### Interface Utilisateur
- **Windows Forms** - Interface graphique desktop
- Design moderne et intuitif

### Base de données
- **SQLite** - Base de données légère et performante
- **Entity Framework** - ORM pour manipulation de données (ou ADO.NET)

### Architecture
- **Modèle MVC (Model-View-Controller)** - Séparation des préoccupations
- **Pattern Repository** - Abstraction de la couche d'accès aux données

## 🏗️ Architecture

Le projet suit l'architecture MVC pour une séparation claire des responsabilités :

```
SmartManagement/
├── Models/              # Entités métier et logique de données
│   ├── Product.cs
│   ├── Category.cs
│   ├── User.cs
│   └── StockMovement.cs
│
├── Views/               # Interfaces utilisateur (Forms)
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── ProductForm.cs
│   └── InventoryForm.cs
│
├── Controllers/         # Logique métier et traitement
│   ├── ProductController.cs
│   ├── UserController.cs
│   └── InventoryController.cs
│
├── Services/           # Services applicatifs
│   ├── AuthService.cs
│   ├── DatabaseService.cs
│   └── ValidationService.cs
│
├── Migrations/         # Scripts de migration base de données
│
└── Program.cs          # Point d'entrée de l'application
```

## ✅ Prérequis

- **Visual Studio 2019+** ou **Visual Studio Code**
- **.NET Framework 4.7.2+** ou **.NET 6.0+**
- **SQLite** (inclus via NuGet)
- **Windows 10+** (pour Windows Forms)

## 🔧 Installation

### 1. Cloner le repository

```bash
git clone https://github.com/votre-username/SmartManagement.git
cd SmartManagement
```

### 2. Ouvrir le projet dans Visual Studio

```bash
# Double-cliquer sur le fichier .sln
SmartManagement.sln
```

### 3. Restaurer les packages NuGet

Dans Visual Studio :
- Clic droit sur la solution
- Sélectionner "Restore NuGet Packages"

Ou via la console :
```bash
dotnet restore
```

### 4. Configurer la base de données

La base de données SQLite sera créée automatiquement au premier lancement. Si nécessaire, vous pouvez exécuter les migrations :

```bash
dotnet ef database update
```

### 5. Compiler et exécuter

```bash
dotnet run
```

Ou appuyez sur **F5** dans Visual Studio.

## 🎯 Utilisation

### Premier lancement

1. **Authentification par défaut** :
   - Utilisateur : `admin`
   - Mot de passe : `admin123`
   
   ⚠️ **Important** : Changez ces identifiants après la première connexion !

### Gestion des produits

#### Ajouter un produit
1. Cliquer sur "Nouveau Produit"
2. Remplir les informations :
   - Nom du produit
   - Description
   - Catégorie
   - Prix unitaire
   - Quantité en stock
   - Code-barres (optionnel)
3. Valider avec "Enregistrer"

#### Modifier un produit
1. Sélectionner le produit dans la liste
2. Cliquer sur "Modifier"
3. Mettre à jour les informations
4. Sauvegarder les modifications

#### Supprimer un produit
1. Sélectionner le produit
2. Cliquer sur "Supprimer"
3. Confirmer l'action

### Mise à jour du stock

1. Sélectionner le produit
2. Cliquer sur "Ajuster Stock"
3. Choisir l'opération :
   - **Entrée** : Ajouter des unités
   - **Sortie** : Retirer des unités
4. Saisir la quantité
5. Ajouter un commentaire (optionnel)
6. Valider

### Consultation de l'inventaire

- Vue d'ensemble : Tableau récapitulatif de tous les produits
- Filtres disponibles :
  - Par catégorie
  - Par niveau de stock
  - Par date d'ajout
- Export possible en Excel/PDF

## 📁 Structure du projet

```
SmartManagement/
│
├── Controllers/                    # Contrôleurs MVC
│   ├── ProductController.cs       # Logique produits
│   ├── UserController.cs          # Logique utilisateurs
│   └── InventoryController.cs     # Logique inventaire
│
├── Models/                        # Modèles de données
│   ├── Product.cs                # Entité Produit
│   ├── Category.cs               # Entité Catégorie
│   ├── User.cs                   # Entité Utilisateur
│   └── StockMovement.cs          # Mouvements de stock
│
├── Views/                        # Interfaces graphiques
│   ├── LoginForm.cs              # Écran de connexion
│   ├── MainForm.cs               # Menu principal
│   ├── ProductManagement.cs      # Gestion des produits
│   └── InventoryView.cs          # Vue de l'inventaire
│
├── Services/                     # Services métier
│   ├── AuthService.cs            # Service d'authentification
│   ├── DatabaseService.cs        # Service de base de données
│   ├── ValidationService.cs      # Service de validation
│   └── ExportService.cs          # Service d'export
│
├── Migrations/                   # Migrations EF Core
│   └── InitialCreate.cs
│
├── Properties/                   # Propriétés du projet
│   └── Settings.settings
│
├── Form1.Designer.cs            # Designer du formulaire principal
├── Form1.cs                     # Code du formulaire principal
├── Form1.resx                   # Ressources du formulaire
├── Program.cs                   # Point d'entrée
└── SmartManagement.csproj       # Fichier de projet
```

## 💾 Base de données

### Schéma SQLite

#### Table `Products`
```sql
CREATE TABLE Products (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Description TEXT,
    CategoryId INTEGER,
    Price REAL NOT NULL,
    Quantity INTEGER DEFAULT 0,
    Barcode TEXT UNIQUE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);
```

#### Table `Categories`
```sql
CREATE TABLE Categories (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL UNIQUE,
    Description TEXT
);
```

#### Table `Users`
```sql
CREATE TABLE Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    Role TEXT DEFAULT 'User',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);
```

#### Table `StockMovements`
```sql
CREATE TABLE StockMovements (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    ProductId INTEGER NOT NULL,
    Type TEXT NOT NULL, -- 'IN' ou 'OUT'
    Quantity INTEGER NOT NULL,
    Comment TEXT,
    UserId INTEGER,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);
```

### Localisation de la base de données

La base de données SQLite est stockée dans :
```
C:\Users\MSI\AppData\Local\SmartManagement\stock.db
```

## 🛠️ Développement

### Ajouter une nouvelle fonctionnalité

1. Créer le modèle dans `/Models`
2. Créer le contrôleur dans `/Controllers`
3. Créer la vue dans `/Views`
4. Mettre à jour la migration si nécessaire

### Conventions de code

- **Nommage** : PascalCase pour classes et méthodes
- **Commentaires** : XML Documentation pour méthodes publiques
- **Gestion d'erreurs** : try-catch avec logging approprié

## 🐛 Dépannage

### La base de données ne se crée pas
```bash
# Supprimer la base existante et recréer
dotnet ef database drop
dotnet ef database update
```

### Erreur de connexion SQLite
Vérifier que le package NuGet `System.Data.SQLite` est installé :
```bash
dotnet add package System.Data.SQLite
```

### Problème d'authentification
Réinitialiser le mot de passe admin via la base de données directement.

## 📝 Améliorations futures

- [ ] Export de rapports en Excel/PDF
- [ ] Système de notifications pour stock bas
- [ ] Gestion multi-utilisateurs avancée
- [ ] Dashboard avec graphiques interactifs
- [ ] Scan de code-barres
- [ ] API REST pour intégration mobile
- [ ] Sauvegarde automatique cloud

## 🤝 Contributions

Les contributions sont les bienvenues ! Pour contribuer :

1. Fork le projet
2. Créer une branche (`git checkout -b feature/AmazingFeature`)
3. Commit les changements (`git commit -m 'Add AmazingFeature'`)
4. Push vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrir une Pull Request

## 📄 Licence

Ce projet est sous licence MIT. Voir le fichier `LICENSE` pour plus de détails.

## 👤 Auteur

**Doula Salma**
- GitHub: [@SalmaDoula]((https://github.com/SelmaDaoula))
- Email: selma.doula@polytechnicien.tn

---

⭐ Si ce projet vous est utile, n'hésitez pas à le mettre en favori !


*Développé avec ❤️ pour simplifier la gestion de stock*
