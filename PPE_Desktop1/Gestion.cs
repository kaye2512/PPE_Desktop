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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAfficher_MouseClick(object sender, MouseEventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "projet";
            dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code;
            if (dbCon.IsConnect())
            {
                string query = "SELECT id, nom, prenom, Email, ville FROM visiteur ORDER BY nom";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                List<Visiteur> DesVisiteurs = new List<Visiteur>();
                while (reader.Read())
                {
                    Visiteur visiteur = new Visiteur()
                    {
                        visiteurid = (int)reader["id"],
                        visiteurnom = (string)reader["nom"],
                        visiteurprenom = (string)reader["prenom"],
                        visiteurEmail = (string)reader["Email"],
                        visiteurville = (string)reader["ville"]

                    };
                    DesVisiteurs.Add(visiteur);

                }
                MaGrid.DataSource = null;
                MaGrid.DataSource = DesVisiteurs;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                MaGrid.Visible = true;
            }
        }

        private void btAjouter_MouseClick(object sender, MouseEventArgs e)
        {
            Visiteur UnParticipant = new Visiteur();
            UnParticipant.visiteurid = 0;//Pour être sur qu'il soit inséré
            Ajouter MonFormParticipant = new Ajouter(UnParticipant);
            MonFormParticipant.Show();
        }

        private void FormaterListe()
        {
            MaGrid.Columns["visiteurid"].Visible = false;
            MaGrid.Columns["visiteurnom"].HeaderText = "Nom du participant";
            MaGrid.Columns["visiteurnom"].Width = 150;
            MaGrid.MultiSelect = false;
            MaGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MaGrid.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaGrid.Visible = false;
        }

        private void btOuvrir_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in MaGrid.SelectedRows)
            {
                Visiteur UnParticipant = row.DataBoundItem as Visiteur;
                Ajouter MonFormParticipant = new Ajouter(UnParticipant);
                MonFormParticipant.Show();

            }
        }

        private void btSupprimer_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in MaGrid.SelectedRows)
            {
                Visiteur UnParticipant = row.DataBoundItem as Visiteur;
                if (UnParticipant.Delete())
                    MessageBox.Show("Participant Supprimé !");
                // Ici on rafraîchit la liste....
                else
                    MessageBox.Show("Impossible de  Supprimer !");

            }
        }

        private void btRechercher_MouseClick(object sender, MouseEventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "projet";
            dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT id, nom, prenom, Email, ville FROM visiteur where nom =?nom ORDER BY nom";
                query = Tools.PrepareLigne(query, "?nom", Tools.PrepareChamp(tbNom.Text, "Chaine"));

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                List<Visiteur> DesVisiteurs = new List<Visiteur>();
                while (reader.Read())
                {
                    Visiteur visiteur = new Visiteur
                    {
                        visiteurid = (int)reader["id"],
                        visiteurnom = (string)reader["nom"],
                        visiteurprenom = (string)reader["prenom"],
                        visiteurEmail = (string)reader["Email"],
                        visiteurville = (string)reader["ville"]
                    };
                    DesVisiteurs.Add(visiteur);
                }

                MaGrid.DataSource = null;
                MaGrid.DataSource = DesVisiteurs;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                MaGrid.Visible = true;
            }
        }
    }
}
