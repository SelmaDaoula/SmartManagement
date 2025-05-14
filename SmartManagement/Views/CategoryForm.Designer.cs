namespace SmartManagement.Views
{
    partial class CategoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewCategories = new DataGridView();
            txtNom = new TextBox();
            lblNom = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(109, 30);
            dataGridViewCategories.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(400, 250);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(179, 308);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(200, 27);
            txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(109, 312);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom :";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(109, 358);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(90, 38);
            btnAjouter.TabIndex = 3;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(229, 358);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(90, 38);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(349, 358);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(90, 38);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 487);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(dataGridViewCategories);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryForm";
            Text = "Gestion des Catégories";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
