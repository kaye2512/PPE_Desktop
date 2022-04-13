namespace PPE_Desktop1
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAjout = new System.Windows.Forms.Button();
            this.btRecherche = new System.Windows.Forms.Button();
            this.btGenere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(317, 154);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 0;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            // 
            // btRecherche
            // 
            this.btRecherche.Location = new System.Drawing.Point(317, 214);
            this.btRecherche.Name = "btRecherche";
            this.btRecherche.Size = new System.Drawing.Size(75, 23);
            this.btRecherche.TabIndex = 1;
            this.btRecherche.Text = "rechercher";
            this.btRecherche.UseVisualStyleBackColor = true;
            // 
            // btGenere
            // 
            this.btGenere.Location = new System.Drawing.Point(317, 268);
            this.btGenere.Name = "btGenere";
            this.btGenere.Size = new System.Drawing.Size(75, 23);
            this.btGenere.TabIndex = 2;
            this.btGenere.Text = "Générer";
            this.btGenere.UseVisualStyleBackColor = true;
            this.btGenere.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGenere_MouseClick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGenere);
            this.Controls.Add(this.btRecherche);
            this.Controls.Add(this.btAjout);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAjout;
        private Button btRecherche;
        private Button btGenere;
    }
}