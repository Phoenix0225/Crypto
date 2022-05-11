using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{
    public partial class Crypto : Form
    {
        public Crypto()
        {
            InitializeComponent();

            cbMethodeCryptage.SelectedIndex = 0;
        }

        private void BtCrypter_Click(object sender, EventArgs e)
        {
            if(tbTxtCryptage.Text.Equals("") || cbMethodeCryptage.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Certains champs obligatoires n'ont pas été complétés.",
                                "Crypto - ERREUR",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int methodeCryptage = Convert.ToInt32(cbMethodeCryptage.SelectedItem.ToString().Substring(0, 1));

            switch (methodeCryptage)
            {
                case 1: tbTxtCrypte.Text = CL.CryptoAES.Encrypt(tbTxtCryptage.Text); break;
                case 2: tbTxtCrypte.Text = CL.CryptageRijndaelManage.Encrypt(tbTxtCryptage.Text); break;
                case 3: tbTxtCrypte.Text = CL.CryptageSHA.Encrypt(tbTxtCryptage.Text); break;
                case 4: tbTxtCrypte.Text = CL.CryptageDES.Encrypt(tbTxtCryptage.Text); break;
            }
        }
    }
}
