using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        RSAParameters privateKey;
        RSAParameters publicKey;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);

            richTextBoxInfo.Text = RSA.ToXmlString(true);
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] input = byteConverter.GetBytes(richTextBoxCode.Text);
            byte[] output;
            output = RSAEncrypt(input, publicKey, false);
            richTextBoxCoded.Text = Convert.ToBase64String(output);
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] input = Convert.FromBase64String(richTextBoxCoded.Text);
            byte[] output;
            output = RSADecrypt(input, privateKey, false);
            richTextBoxEncoded.Text = byteConverter.GetString(output);
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }
    }
}
