namespace PPE_Desktop1
{
    partial class Ajouter
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
            this.btResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCodeB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(318, 304);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(185, 23);
            this.btResult.TabIndex = 0;
            this.btResult.Text = "Valider";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "codeB";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(318, 66);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(209, 23);
            this.tbNom.TabIndex = 6;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(317, 105);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(210, 23);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(316, 144);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(211, 23);
            this.tbMail.TabIndex = 8;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(314, 183);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(213, 23);
            this.tbVille.TabIndex = 9;
            // 
            // tbCodeB
            // 
            this.tbCodeB.Location = new System.Drawing.Point(316, 216);
            this.tbCodeB.Name = "tbCodeB";
            this.tbCodeB.Size = new System.Drawing.Size(211, 23);
            this.tbCodeB.TabIndex = 10;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCodeB);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btResult);
            this.Name = "Ajouter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private TextBox tbMail;
        private TextBox tbVille;
        private TextBox tbCodeB;
    }
}