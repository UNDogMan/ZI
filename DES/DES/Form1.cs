using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DES
{
    public partial class Form1 : Form
    {
        readonly byte[] IV = { 0x65, 0x28 , 0xDB , 0x2B , 0xB4 , 0xCF , 0x7B, 0xFB };

        byte[] key1;
        byte[] key2;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenKey1_Click(object sender, EventArgs e)
        {
            if (textBoxKey1.Text.Length != 7 && !String.IsNullOrEmpty(textBoxKey1.Text))
            {
                MessageBox.Show("Enter 7 chars or leave empty");
                return;
            }
            if (textBoxKey1.Text.Length == 0)
                key1 = new DESCryptoServiceProvider().Key;
            else
                key1 = String.Join("",
                    Encoding.ASCII.GetBytes(textBoxKey1.Text)
                    .Select(x => Convert.ToString(x, 2).PadLeft(8, '0')))
                    .SplitIntoChunks(7)
                    .Select(x => Convert.ToByte(x + x.AdditionNum(), 2))
                    .ToArray();

            labelKey1.Text = BitConverter.ToString(key1);
        }

        private void buttonGenKey2_Click(object sender, EventArgs e)
        {
            if (textBoxKey2.Text.Length != 7 && !String.IsNullOrEmpty(textBoxKey2.Text))
            {
                MessageBox.Show("Enter 7 chars or leave empty");
                return;
            }
            if (textBoxKey2.Text.Length == 0)
                key2 = new DESCryptoServiceProvider().Key;
            else
                key2 = String.Join("",
                    Encoding.ASCII.GetBytes(textBoxKey2.Text)
                    .Select(x => Convert.ToString(x, 2).PadLeft(8, '0')))
                    .SplitIntoChunks(7)
                    .Select(x => Convert.ToByte(x + x.AdditionNum(), 2))
                    .ToArray();

            labelKey2.Text = BitConverter.ToString(key2);
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            if(key1 is null || key2 is null)
                return;
            string originalString = richTextBoxBase.Text;
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(key1, IV), CryptoStreamMode.Write);
            CryptoStream cryptoStream1 = new CryptoStream(cryptoStream,
                cryptoProvider.CreateEncryptor(key1, IV), CryptoStreamMode.Write);
            CryptoStream cryptoStream2 = new CryptoStream(cryptoStream1,
                cryptoProvider.CreateEncryptor(key1, IV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream2);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream2.FlushFinalBlock();
            writer.Flush();
            richTextBoxCoded.Text = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedString = richTextBoxCoded.Text;
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(key1, IV), CryptoStreamMode.Read);
            CryptoStream cryptoStream1 = new CryptoStream(cryptoStream,
                cryptoProvider.CreateDecryptor(key1, IV), CryptoStreamMode.Read);
            CryptoStream cryptoStream2 = new CryptoStream(cryptoStream1,
                cryptoProvider.CreateDecryptor(key1, IV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream2);
            richTextBoxBase.Text = reader.ReadToEnd();
        }
    }
}
