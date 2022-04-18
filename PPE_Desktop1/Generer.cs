using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using MySql.Data.MySqlClient;

namespace PPE_Desktop1
{
    public partial class Generer : Form
    {
        public Generer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(tbNom.Text + tbPrenom + tbMail, QRCodeGenerator.ECCLevel.Q);

                Base64QRCode qrCode = new Base64QRCode(qrCodeData);
                string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

                StreamWriter monStreamWriter = new StreamWriter(@"BadgeSalon.html");

                String strImage = "<img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
                monStreamWriter.WriteLine("<html>");
                monStreamWriter.WriteLine("<body>");
                string temptext = "<P>" + tbNom + "<P>";
                monStreamWriter.WriteLine(temptext);
                temptext = "<P>" + tbPrenom + "<P>";
                monStreamWriter.WriteLine(temptext);
                temptext = "<p>" + tbMail + "<p>";
                monStreamWriter.WriteLine(temptext);
                monStreamWriter.WriteLine(strImage);
                monStreamWriter.WriteLine("</body>");
                monStreamWriter.WriteLine("</html>");

                monStreamWriter.Close();
                
               
          
        }
    }
}
