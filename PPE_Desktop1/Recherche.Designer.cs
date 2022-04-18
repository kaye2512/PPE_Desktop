namespace PPE_Desktop1
{
    partial class Recherche
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
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResultaRecherche = new System.Windows.Forms.TextBox();
            this.btRecherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(249, 110);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(339, 23);
            this.tbRecherche.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche :";
            // 
            // tbResultaRecherche
            // 
            this.tbResultaRecherche.Location = new System.Drawing.Point(249, 259);
            this.tbResultaRecherche.Name = "tbResultaRecherche";
            this.tbResultaRecherche.Size = new System.Drawing.Size(339, 23);
            this.tbResultaRecherche.TabIndex = 2;
            // 
            // btRecherche
            // 
            this.btRecherche.Location = new System.Drawing.Point(390, 342);
            this.btRecherche.Name = "btRecherche";
            this.btRecherche.Size = new System.Drawing.Size(167, 23);
            this.btRecherche.TabIndex = 3;
            this.btRecherche.Text = "Valider";
            this.btRecherche.UseVisualStyleBackColor = true;
            this.btRecherche.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRecherche_MouseClick);
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRecherche);
            this.Controls.Add(this.tbResultaRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRecherche);
            this.Name = "Recherche";
            this.Text = "Recherche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbRecherche;
        private Label label1;
        private TextBox tbResultaRecherche;
        private Button btRecherche;
    }
}