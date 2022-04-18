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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }
        Interface Myinterface = new Interface();
        private void btConnect_MouseClick(object sender, MouseEventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "sucrerie";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("khCCx1daKtw=");//Pour éviter d'afficher le mot de passe en clair dans le code;
            if (dbCon.IsConnect())
            {
              Myinterface.Show();
                
            }
            else
            {
                tbResultat.Text = "Error : Opening Database";
            }
        }
    }
}
