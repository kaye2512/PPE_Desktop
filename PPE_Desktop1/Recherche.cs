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
namespace PPE_Desktop1
{
    public partial class Recherche : Form
    {
        public Recherche()
        {
            InitializeComponent();
        }

        private void btRecherche_MouseClick(object sender, MouseEventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("khCCx1daKtw=");//Pour éviter d'afficher le mot de passe en clair dans le code;
            if (dbCon.IsConnect())
            {
                string visiteurnom;
                visiteurnom = tbRecherche.Text;

                string query = "select id, nom, prenom, Email, ville from visiteur where nom =?nom;";
                query = Tools.PrepareLigne(query, "?nom", Tools.PrepareChamp(visiteurnom, "Chaine"));

                var cmd = new MySqlCommand(query, dbCon.Connection);
                List<Visiteur> LesVisiteurTrouver = new List<Visiteur>();
                var TheReader = cmd.ExecuteReader();//on arrive a la fin il faut recharger le reader
                while (TheReader.Read())
                {
                    Visiteur Unvisiteur = new Visiteur()
                    {
                        visiteurid = (int)TheReader["id"],
                        visiteurnom = (string)TheReader["nom"],
                        visiteurprenom = (string)TheReader["prenom"],
                        visiteurEmail = (string)TheReader["Email"],
                        visiteurville = (string)TheReader["ville"],
                        
                    };
                    LesVisiteurTrouver.Add(Unvisiteur);

                }
                if (LesVisiteurTrouver.Count > 0)
                {
                    
                    foreach (Visiteur Unvisiteur in LesVisiteurTrouver)

                        tbResultaRecherche.Text = (Unvisiteur.visiteurid.ToString() + "," + Unvisiteur.visiteurnom + "," + Unvisiteur.visiteurprenom + "," + Unvisiteur.visiteurEmail + "," + Unvisiteur.visiteurville );
                }
                else
                   
                TheReader.Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
