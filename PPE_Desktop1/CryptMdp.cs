using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Desktop1
{
    public partial class CryptMdp : Form
    {
        public CryptMdp()
        {
            InitializeComponent();
        }

        private void btCryptDecrypt_MouseClick(object sender, MouseEventArgs e)
        {

            if(tbCrypt.TextLength == 0)
            {
                tbCrypt.Text = Crypto.Encrypt(tbDecrypt.Text);
            }
            else
            {
                tbDecrypt.Text = Crypto.Decrypt(tbCrypt.Text);
            }
            

            
        }
    }
}
