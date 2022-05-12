namespace PPE_Desktop1
{
    partial class CryptMdp
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
            this.tbDecrypt = new System.Windows.Forms.TextBox();
            this.tbCrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCryptDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDecrypt
            // 
            this.tbDecrypt.Location = new System.Drawing.Point(271, 79);
            this.tbDecrypt.Name = "tbDecrypt";
            this.tbDecrypt.Size = new System.Drawing.Size(279, 23);
            this.tbDecrypt.TabIndex = 0;
            // 
            // tbCrypt
            // 
            this.tbCrypt.Location = new System.Drawing.Point(271, 190);
            this.tbCrypt.Name = "tbCrypt";
            this.tbCrypt.Size = new System.Drawing.Size(279, 23);
            this.tbCrypt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "crypt";
            // 
            // btCryptDecrypt
            // 
            this.btCryptDecrypt.Location = new System.Drawing.Point(442, 330);
            this.btCryptDecrypt.Name = "btCryptDecrypt";
            this.btCryptDecrypt.Size = new System.Drawing.Size(108, 23);
            this.btCryptDecrypt.TabIndex = 4;
            this.btCryptDecrypt.Text = "crypt/decrypt";
            this.btCryptDecrypt.UseVisualStyleBackColor = true;
            this.btCryptDecrypt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCryptDecrypt_MouseClick);
            // 
            // CryptMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCryptDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCrypt);
            this.Controls.Add(this.tbDecrypt);
            this.Name = "CryptMdp";
            this.Text = "CryptMdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDecrypt;
        private TextBox tbCrypt;
        private Label label1;
        private Label label2;
        private Button btCryptDecrypt;
    }
}