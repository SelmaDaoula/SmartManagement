namespace SmartManagement.Views
{
    partial class ProdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Quantié_Stock = new DataGridViewTextBoxColumn();
            PrixUnitaire = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            ProductCategoryBox = new ComboBox();
            DeleteButton = new Button();
            ModifyButton = new Button();
            AddButton = new Button();
            ProductIAlertSeuil = new TextBox();
            ProductPrice = new TextBox();
            ProductQuantity = new TextBox();
            ProductName = new TextBox();
            ProductId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            sqliteCommand2 = new Microsoft.Data.Sqlite.SqliteCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 270);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(844, 270);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 125;
            // 
            // Quantié_Stock
            // 
            Quantié_Stock.HeaderText = "Quantié_Stock";
            Quantié_Stock.MinimumWidth = 6;
            Quantié_Stock.Name = "Quantié_Stock";
            Quantié_Stock.ReadOnly = true;
            Quantié_Stock.Width = 125;
            // 
            // PrixUnitaire
            // 
            PrixUnitaire.HeaderText = "PrixUnitaire";
            PrixUnitaire.MinimumWidth = 6;
            PrixUnitaire.Name = "PrixUnitaire";
            PrixUnitaire.ReadOnly = true;
            PrixUnitaire.Width = 125;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categorie";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.ReadOnly = true;
            Categorie.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(ProductCategoryBox);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(ModifyButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(ProductIAlertSeuil);
            panel2.Controls.Add(ProductPrice);
            panel2.Controls.Add(ProductQuantity);
            panel2.Controls.Add(ProductName);
            panel2.Controls.Add(ProductId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 222);
            panel2.TabIndex = 1;
            // 
            // ProductCategoryBox
            // 
            ProductCategoryBox.FormattingEnabled = true;
            ProductCategoryBox.Location = new Point(185, 120);
            ProductCategoryBox.Name = "ProductCategoryBox";
            ProductCategoryBox.Size = new Size(125, 28);
            ProductCategoryBox.TabIndex = 13;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(493, 168);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += btnSupprimer_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(369, 168);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(94, 29);
            ModifyButton.TabIndex = 11;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(240, 168);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ProductIAlertSeuil
            // 
            ProductIAlertSeuil.Location = new Point(454, 120);
            ProductIAlertSeuil.Name = "ProductIAlertSeuil";
            ProductIAlertSeuil.Size = new Size(125, 27);
            ProductIAlertSeuil.TabIndex = 10;
            // 
            // ProductPrice
            // 
            ProductPrice.Location = new Point(454, 70);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(125, 27);
            ProductPrice.TabIndex = 9;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Location = new Point(454, 29);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(125, 27);
            ProductQuantity.TabIndex = 8;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(185, 73);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(125, 27);
            ProductName.TabIndex = 7;
            // 
            // ProductId
            // 
            ProductId.Location = new Point(185, 32);
            ProductId.Name = "ProductId";
            ProductId.Size = new Size(125, 27);
            ProductId.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(349, 120);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 5;
            label7.Text = "Seuil Alerte";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(393, 73);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 4;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(369, 32);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 3;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 120);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 2;
            label4.Text = "Product Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 73);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Product_id";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // sqliteCommand2
            // 
            sqliteCommand2.CommandTimeout = 30;
            sqliteCommand2.Connection = null;
            sqliteCommand2.Transaction = null;
            sqliteCommand2.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ProdForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
        //    FormBorderStyle = FormBorderStyle.None;
            Name = "ProdForm";
            Text = "ProdForm";
            Load += ProdForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox ProductIAlertSeuil;
        private TextBox ProductPrice;
        private TextBox ProductQuantity;
        private TextBox ProductName;
        private TextBox ProductId;
        private Button ModifyButton;
        private Button AddButton;
        private ComboBox ProductCategoryBox;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Quantié_Stock;
        private DataGridViewTextBoxColumn PrixUnitaire;
        private DataGridViewTextBoxColumn Categorie;
        
        private DataGridView dataGridView1;
    }
}