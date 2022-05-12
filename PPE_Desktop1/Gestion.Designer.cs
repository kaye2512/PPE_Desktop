namespace PPE_Desktop1
{
    partial class Form1
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
            this.btAjouter = new System.Windows.Forms.Button();
            this.btOuvrir = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btRechercher = new System.Windows.Forms.Button();
            this.btAfficher = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(815, 152);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(124, 23);
            this.btAjouter.TabIndex = 0;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAjouter_MouseClick);
            // 
            // btOuvrir
            // 
            this.btOuvrir.Location = new System.Drawing.Point(815, 231);
            this.btOuvrir.Name = "btOuvrir";
            this.btOuvrir.Size = new System.Drawing.Size(124, 23);
            this.btOuvrir.TabIndex = 1;
            this.btOuvrir.Text = "Ouvrir";
            this.btOuvrir.UseVisualStyleBackColor = true;
            this.btOuvrir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btOuvrir_MouseClick);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(815, 313);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(124, 23);
            this.btSupprimer.TabIndex = 1;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSupprimer_MouseClick);
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(525, 74);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(180, 23);
            this.btRechercher.TabIndex = 2;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRechercher_MouseClick);
            // 
            // btAfficher
            // 
            this.btAfficher.Location = new System.Drawing.Point(738, 74);
            this.btAfficher.Name = "btAfficher";
            this.btAfficher.Size = new System.Drawing.Size(180, 23);
            this.btAfficher.TabIndex = 2;
            this.btAfficher.Text = "Afficher tous les visiteurs";
            this.btAfficher.UseVisualStyleBackColor = true;
            this.btAfficher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAfficher_MouseClick);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(145, 75);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(342, 23);
            this.tbNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // MaGrid
            // 
            this.MaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaGrid.Location = new System.Drawing.Point(40, 152);
            this.MaGrid.Name = "MaGrid";
            this.MaGrid.RowTemplate.Height = 25;
            this.MaGrid.Size = new System.Drawing.Size(665, 434);
            this.MaGrid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 637);
            this.Controls.Add(this.MaGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btAfficher);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btOuvrir);
            this.Controls.Add(this.btAjouter);
            this.Name = "Form1";
            this.Text = "Gestions des Salons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAjouter;
        private Button btOuvrir;
        private Button btSupprimer;
        private Button btRechercher;
        private Button btAfficher;
        private TextBox tbNom;
        private Label label1;
        private DataGridView MaGrid;
    }
}