using System;
using System.Data;
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
        
       
        

        public void Save()

        {
            if (visiteurid > 0)
                UpdateContact();
            else
                AddContact();
        }

        public bool Delete()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "localhost";
                dbCon.DatabaseName = "sucrerie";
                dbCon.UserName = "projet";
                dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code;
                if(dbCon.IsConnect()){
                    String sqlString = "DELETE FROM visiteur WHERE id = ?id";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
               return false;
            }

        }

        

      
        private void AddContact()
        {
            try {

                DBConnection dbCon = new DBConnection();
                dbCon.Server = "localhost";
                dbCon.DatabaseName = "sucrerie";
                dbCon.UserName = "projet";
                dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code;
                if (dbCon.IsConnect())
                {
                    String sqlString = "INSERT INTO visiteur(nom,prenom,Email,ville,codeB) VALUES(?nom,?prenom,?Email,?ville,?codeB)";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(visiteurnom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(visiteurprenom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Email", Tools.PrepareChamp(visiteurEmail, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(visiteurville, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        private void UpdateContact()
        {

            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "localhost";
                dbCon.DatabaseName = "sucrerie";
                dbCon.UserName = "projet";
                dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code;
                if (dbCon.IsConnect())
                {
                    String sqlString = "UPDATE visiteur SET nom = ?nom, prenom = ?prenom,ville = ?ville WHERE id = ?id";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(visiteurid.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(visiteurnom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(visiteurprenom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Email", Tools.PrepareChamp(visiteurEmail, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(visiteurville, "Chaine"));


                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();  
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        private int AppelerProcedureStockee()
        {
            try
            {

                DBConnection dbCon = new DBConnection();
                dbCon.Server = "localhost";
                dbCon.DatabaseName = "sucrerie";
                dbCon.UserName = "projet";
                dbCon.Password = Crypto.Decrypt("CEUHeZWVihZOqo2QusEkwQ==");//Pour éviter d'afficher le mot de passe en clair dans le code;
                int Identifiant = -1;
                if (dbCon.IsConnect())
                {
                    String sqlString = "GiveId";
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                    cmd.Parameters.Add("@TheID", MySqlDbType.Int32);
                    cmd.Parameters["@TheID"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    Identifiant = (int)cmd.Parameters["@TheID"].Value;
                    dbCon.Close();
                    return Identifiant + 1;
                }
                dbCon.Close();
                return -1;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return -1;
            }
        }

    }

}
  

