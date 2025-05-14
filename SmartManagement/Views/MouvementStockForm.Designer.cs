using System.Windows.Forms;

namespace SmartManagement.Views
{
    partial class MouvementStockForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbTypeMouvement = new ComboBox();
            this.cbProduits = new ComboBox();
            this.txtQuantite = new TextBox();
            this.btnAjouter = new Button();
            this.dataGridViewMouvements = new DataGridView();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMouvements)).BeginInit();
            this.SuspendLayout();

            // cbTypeMouvement
            this.cbTypeMouvement.FormattingEnabled = true;
            this.cbTypeMouvement.Location = new System.Drawing.Point(12, 35);
            this.cbTypeMouvement.Name = "cbTypeMouvement";
            this.cbTypeMouvement.Size = new System.Drawing.Size(200, 28);
            this.cbTypeMouvement.TabIndex = 0;

            // cbProduits
            this.cbProduits.FormattingEnabled = true;
            this.cbProduits.Location = new System.Drawing.Point(12, 96);
            this.cbProduits.Name = "cbProduits";
            this.cbProduits.Size = new System.Drawing.Size(200, 28);
            this.cbProduits.TabIndex = 1;

            // txtQuantite
            this.txtQuantite.Location = new System.Drawing.Point(12, 157);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(200, 27);
            this.txtQuantite.TabIndex = 2;

            // btnAjouter
            this.btnAjouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(12, 200);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 40);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter Mouvement";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // dataGridViewMouvements
            this.dataGridViewMouvements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMouvements.Location = new System.Drawing.Point(250, 35);
            this.dataGridViewMouvements.Name = "dataGridViewMouvements";
            this.dataGridViewMouvements.RowHeadersWidth = 51;
            this.dataGridViewMouvements.RowTemplate.Height = 29;
            this.dataGridViewMouvements.Size = new System.Drawing.Size(530, 350);
            this.dataGridViewMouvements.TabIndex = 4;
            this.dataGridViewMouvements.BorderStyle = BorderStyle.Fixed3D;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type de Mouvement";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produit";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantité";

            // MouvementStockForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMouvements);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbProduits);
            this.Controls.Add(this.cbTypeMouvement);
            this.Name = "MouvementStockForm";
            this.Text = "Mouvement de Stock";
            this.Load += new System.EventHandler(this.MouvementStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMouvements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ComboBox cbTypeMouvement;
        private ComboBox cbProduits;
        private TextBox txtQuantite;
        private Button btnAjouter;
        private DataGridView dataGridViewMouvements;
        private Label label1;
        private Label label2;  // Correction ici, Label2 devient Label
        private Label label3;
    }
}
