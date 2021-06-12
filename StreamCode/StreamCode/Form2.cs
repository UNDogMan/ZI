using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamCode
{
    public partial class Form2 : Form
    {
        RC4 rc4;
        byte[] key;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            key = textBoxKey.Text.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => byte.Parse(x)).ToArray();
            labelGen.Text = "Yes";
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            rc4 = new RC4(key);

            byte[] testBytes = ASCIIEncoding.ASCII.GetBytes(richTextBox1.Text);
            byte[] result = rc4.Encode(testBytes, testBytes.Length);

            richTextBox2.Text = Convert.ToBase64String(result);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            rc4 = new RC4(key);

            byte[] data = Convert.FromBase64String(richTextBox2.Text);

            byte[] decryptedBytes = rc4.Decode(data, data.Length);
            string decryptedString = ASCIIEncoding.ASCII.GetString(decryptedBytes);

            richTextBox1.Text = decryptedString;
        }
    }
}
