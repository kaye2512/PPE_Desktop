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
namespace PPE_Desktop1
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        

        private void btResult_Click(object sender, EventArgs e)
        {

            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("khCCx1daKtw=");//Pour éviter d'afficher le mot de passe en clair dans le code;
            if (dbCon.IsConnect())
            {

                string query = "select id, nom, prenom, Email, ville, codeB from visiteur;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                reader.Close();
                Visiteur UnVisiteur = new Visiteur();
                String nom, prenom, Email, ville, codeB;
                nom = tbNom.Text;
                prenom = tbPrenom.Text;
                Email = tbMail.Text;
                ville = tbVille.Text;
                codeB = tbCodeB.Text;
                //Ici on effectue l'enregistrement dans la BDD
                UnVisiteur.Init(nom, prenom, Email, ville, codeB);
                UnVisiteur.Save(dbCon, reader);
                tbNom.Clear();
                tbPrenom.Clear();
                tbMail.Clear();
                tbVille.Clear();
                tbCodeB.Clear();
                           
                            
                
                
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
