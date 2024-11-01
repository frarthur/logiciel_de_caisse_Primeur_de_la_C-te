namespace logiciel_de_caisse_Primeur_de_la_Côte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Left = new System.Windows.Forms.GroupBox();
            this.gb_Right = new System.Windows.Forms.GroupBox();
            this.l_poids = new System.Windows.Forms.Label();
            this.l_produit = new System.Windows.Forms.Label();
            this.ms_Produit = new System.Windows.Forms.MenuStrip();
            this.tb_Poids = new System.Windows.Forms.TextBox();
            this.btt_Ajouter = new System.Windows.Forms.Button();
            this.btt_Afficher = new System.Windows.Forms.Button();
            this.tb_Prix = new System.Windows.Forms.TextBox();
            this.l_Prix = new System.Windows.Forms.Label();
            this.l_Panier = new System.Windows.Forms.Label();
            this.rtb_Panier = new System.Windows.Forms.RichTextBox();
            this.gb_Left.SuspendLayout();
            this.gb_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Left
            // 
            this.gb_Left.Controls.Add(this.btt_Ajouter);
            this.gb_Left.Controls.Add(this.tb_Poids);
            this.gb_Left.Controls.Add(this.l_produit);
            this.gb_Left.Controls.Add(this.ms_Produit);
            this.gb_Left.Controls.Add(this.l_poids);
            this.gb_Left.Location = new System.Drawing.Point(20, 20);
            this.gb_Left.Name = "gb_Left";
            this.gb_Left.Size = new System.Drawing.Size(350, 300);
            this.gb_Left.TabIndex = 0;
            this.gb_Left.TabStop = false;
            // 
            // gb_Right
            // 
            this.gb_Right.Controls.Add(this.rtb_Panier);
            this.gb_Right.Controls.Add(this.l_Panier);
            this.gb_Right.Location = new System.Drawing.Point(420, 20);
            this.gb_Right.Name = "gb_Right";
            this.gb_Right.Size = new System.Drawing.Size(350, 300);
            this.gb_Right.TabIndex = 1;
            this.gb_Right.TabStop = false;
            // 
            // l_poids
            // 
            this.l_poids.AutoSize = true;
            this.l_poids.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_poids.Location = new System.Drawing.Point(6, 110);
            this.l_poids.Name = "l_poids";
            this.l_poids.Size = new System.Drawing.Size(180, 37);
            this.l_poids.TabIndex = 10;
            this.l_poids.Text = "Poids (kg) :";
            this.l_poids.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_produit
            // 
            this.l_produit.AutoSize = true;
            this.l_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_produit.Location = new System.Drawing.Point(6, 22);
            this.l_produit.Name = "l_produit";
            this.l_produit.Size = new System.Drawing.Size(137, 37);
            this.l_produit.TabIndex = 11;
            this.l_produit.Text = "Produit :";
            // 
            // ms_Produit
            // 
            this.ms_Produit.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Produit.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ms_Produit.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ms_Produit.Location = new System.Drawing.Point(156, 27);
            this.ms_Produit.Name = "ms_Produit";
            this.ms_Produit.Size = new System.Drawing.Size(202, 24);
            this.ms_Produit.TabIndex = 12;
            this.ms_Produit.Text = "menuStrip1";
            // 
            // tb_Poids
            // 
            this.tb_Poids.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Poids.Location = new System.Drawing.Point(244, 103);
            this.tb_Poids.Name = "tb_Poids";
            this.tb_Poids.Size = new System.Drawing.Size(100, 44);
            this.tb_Poids.TabIndex = 13;
            // 
            // btt_Ajouter
            // 
            this.btt_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Ajouter.Location = new System.Drawing.Point(13, 179);
            this.btt_Ajouter.Name = "btt_Ajouter";
            this.btt_Ajouter.Size = new System.Drawing.Size(331, 59);
            this.btt_Ajouter.TabIndex = 14;
            this.btt_Ajouter.Text = "Ajouter Article";
            this.btt_Ajouter.UseVisualStyleBackColor = true;
            this.btt_Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_Afficher
            // 
            this.btt_Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Afficher.Location = new System.Drawing.Point(33, 334);
            this.btt_Afficher.Name = "btt_Afficher";
            this.btt_Afficher.Size = new System.Drawing.Size(331, 44);
            this.btt_Afficher.TabIndex = 16;
            this.btt_Afficher.Text = "Voir le ticket";
            this.btt_Afficher.UseVisualStyleBackColor = true;
            // 
            // tb_Prix
            // 
            this.tb_Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Prix.Location = new System.Drawing.Point(599, 335);
            this.tb_Prix.Name = "tb_Prix";
            this.tb_Prix.Size = new System.Drawing.Size(171, 44);
            this.tb_Prix.TabIndex = 18;
            // 
            // l_Prix
            // 
            this.l_Prix.AutoSize = true;
            this.l_Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Prix.Location = new System.Drawing.Point(413, 341);
            this.l_Prix.Name = "l_Prix";
            this.l_Prix.Size = new System.Drawing.Size(180, 37);
            this.l_Prix.TabIndex = 17;
            this.l_Prix.Text = "Poids (kg) :";
            this.l_Prix.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // l_Panier
            // 
            this.l_Panier.AutoSize = true;
            this.l_Panier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Panier.Location = new System.Drawing.Point(6, 14);
            this.l_Panier.Name = "l_Panier";
            this.l_Panier.Size = new System.Drawing.Size(127, 37);
            this.l_Panier.TabIndex = 12;
            this.l_Panier.Text = "Panier :";
            // 
            // rtb_Panier
            // 
            this.rtb_Panier.Location = new System.Drawing.Point(13, 54);
            this.rtb_Panier.Name = "rtb_Panier";
            this.rtb_Panier.Size = new System.Drawing.Size(331, 240);
            this.rtb_Panier.TabIndex = 13;
            this.rtb_Panier.Text = "";
            this.rtb_Panier.TextChanged += new System.EventHandler(this.rtb_Panier_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Controls.Add(this.tb_Prix);
            this.Controls.Add(this.l_Prix);
            this.Controls.Add(this.btt_Afficher);
            this.Controls.Add(this.gb_Right);
            this.Controls.Add(this.gb_Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Left.ResumeLayout(false);
            this.gb_Left.PerformLayout();
            this.gb_Right.ResumeLayout(false);
            this.gb_Right.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Left;
        private System.Windows.Forms.GroupBox gb_Right;
        private System.Windows.Forms.Label l_produit;
        private System.Windows.Forms.MenuStrip ms_Produit;
        private System.Windows.Forms.Label l_poids;
        private System.Windows.Forms.TextBox tb_Poids;
        private System.Windows.Forms.Button btt_Ajouter;
        private System.Windows.Forms.Button btt_Afficher;
        private System.Windows.Forms.TextBox tb_Prix;
        private System.Windows.Forms.Label l_Prix;
        private System.Windows.Forms.RichTextBox rtb_Panier;
        private System.Windows.Forms.Label l_Panier;
    }
}

