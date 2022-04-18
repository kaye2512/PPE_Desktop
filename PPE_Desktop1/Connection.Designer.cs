namespace PPE_Desktop1
{
    partial class Connection
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
            this.btConnect = new System.Windows.Forms.Button();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(265, 164);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(205, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btConnect_MouseClick);
            // 
            // tbResultat
            // 
            this.tbResultat.Location = new System.Drawing.Point(228, 288);
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(315, 23);
            this.tbResultat.TabIndex = 1;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultat);
            this.Controls.Add(this.btConnect);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btConnect;
        private TextBox tbResultat;
    }
}