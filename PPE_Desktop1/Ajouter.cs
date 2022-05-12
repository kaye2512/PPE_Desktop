using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using QRCoder;
namespace PPE_Desktop1
{
    public partial class Ajouter : Form
    {
        Visiteur UnVisiteur;
        public Ajouter(Visiteur UnParticipant)
        {
            InitializeComponent();
            UnVisiteur = UnParticipant;
            tbNom.Text = UnParticipant.visiteurnom;
            tbPrenom.Text = UnParticipant.visiteurprenom;
            tbMail.Text = UnParticipant.visiteurEmail;
            tbVille.Text = UnParticipant.visiteurville;
        }

        

        private void btResult_Click(object sender, EventArgs e)
        {
            Error1.Text = "";
            Error2.Text = "";
            Error3.Text = "";
            Error4.Text = "";
            Error5.Text = "";
            bool IsOK = true;
            if (tbNom.Text.Length == 0)
            {
                Error1.Text = "Le Nom ne peut être vide";
                IsOK = false;
            }
            else UnVisiteur.visiteurnom = tbNom.Text;
            if (tbPrenom.Text.Length == 0)
            {
                Error2.Text = "Le Prénom ne peut être vide";
                IsOK = false;
            }
            else
                UnVisiteur.visiteurprenom = tbPrenom.Text;

            if (MesOutils.VeriferMail(tbMail.Text))
                UnVisiteur.visiteurEmail = tbMail.Text;
            else
            {
                Error3.Text = "email incorrect";
                IsOK = false;
            }
            if (tbVille.Text.Length == 0)
            {
                Error4.Text = "Ville ne peut etre vide";
                IsOK = false;
            }
            else
            {
                UnVisiteur.visiteurville = tbVille.Text;
            }
           
            if (IsOK)
                UnVisiteur.Save();
            Error5.Text = "Enregistrement effectué";
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            Error1.Text = "";
            Error2.Text = "";
            Error3.Text = "";
            Error4.Text = "";
            Error5.Text = "";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            String QRBrut = UnVisiteur.visiteurprenom + " " + UnVisiteur.visiteurnom;
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRBrut, QRCodeGenerator.ECCLevel.Q);

            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

            StreamWriter monStreamWriter = new StreamWriter(@"C:\Temp\BadgeSalon.html");//Necessite using System.IO;

            String strImage = " <img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
            monStreamWriter.WriteLine("<html>");
            monStreamWriter.WriteLine("<body>");
            monStreamWriter.Write(UnVisiteur.visiteurprenom + " ");
            monStreamWriter.WriteLine(UnVisiteur.visiteurnom);

            monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
            monStreamWriter.WriteLine("</body>");
            monStreamWriter.WriteLine("</html>");

            // Fermeture du StreamWriter (Très important) 
            monStreamWriter.Close();
            System.Diagnostics.Process.Start("Opera", @"C:\Temp\BadgeSalon.html");
            MessageBox.Show("Badge généré");
        }
    }
}
