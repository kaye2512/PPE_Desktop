using System;
using MySql.Data.MySqlClient;
namespace PPE_Desktop1
{
    public class Visiteur
    {
        public int visiteurid { get; set; }
        public string visiteurnom{ get; set; }
        public string visiteurprenom { get; set; }
        public string visiteurEmail { get; set; }
        public string visiteurville { get; set; }
        public string visiteurcodeB { get; set; }
       
        public void Init(string nom, string prenom, string Email, string ville, string codeB)
        {
            visiteurnom = nom;
            visiteurprenom = prenom;
            visiteurEmail = Email;
            visiteurville = ville;
            visiteurcodeB = codeB;
        }

        public void Save(DBConnection DataBaseConnection, MySqlDataReader TheReader)

        {
            if (visiteurid > 0)
                UpdateContact(DataBaseConnection, TheReader);
            else
                AddContact(DataBaseConnection, TheReader);
        }

        public void Delete(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            try
            {
                String sqlString = "DELETE FROM visiteur WHERE id = ?id";
                sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        private int GiveNewID(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            int Newid= 0;
            try
            {
                String sqlString = "SELECT MAX(id) FROM visiteur;";
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                TheReader = cmd.ExecuteReader();
            
                while (TheReader.Read())
                { Newid = TheReader.GetInt32(0); }
                TheReader.Close();
                Newid++;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
            return Newid;
        }

      
        private void AddContact( DBConnection DataBaseConnection, MySqlDataReader TheReader )
        {
            try {
                visiteurid = GiveNewID(DataBaseConnection, TheReader);
                String sqlString = "INSERT INTO visiteur(nom,prenom,Email,ville,codeB) VALUES(?nom,?prenom,?Email,?ville,?codeB)";
                sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(visiteurnom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(visiteurprenom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?Email", Tools.PrepareChamp(visiteurEmail, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(visiteurville, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?codeB", Tools.PrepareChamp(visiteurcodeB, "Chaine"));

                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        private void UpdateContact(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            try
            {
                 String sqlString = "UPDATE visiteur SET nom = ?nom, prenom = ?prenom,ville = ?ville WHERE id = ?id";
                //sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(visiteurnom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(visiteurprenom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?Email", Tools.PrepareChamp(visiteurEmail, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(visiteurville, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?codeB", Tools.PrepareChamp(visiteurcodeB, "Chaine"));

                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        

    }

    
}
