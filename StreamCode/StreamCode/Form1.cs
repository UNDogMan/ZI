using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StreamCode
{
    public partial class Form1 : Form
    {
        BBS bbs;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            RSAParameters parameters;
            do
            {
                parameters = RSA.Create((int)numericUpDownBitSize.Value).ExportParameters(true);
            } while (!BBS.Validate(parameters.Q, parameters.P));
            bbs = new BBS(parameters.Q, parameters.P);

            richTextBoxBBS.Text = bbs.ToString();
        }

        private void buttonCreateLong_Click(object sender, EventArgs e)
        {
            try
            {
                bbs = new BBS((long)numericUpDownQ.Value, (long)numericUpDownP.Value);
                richTextBoxBBS.Text = bbs.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGenStream_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            StringBuilder sb = new StringBuilder((int)numericUpDownBitsToGen.Value);
            watch.Start();
            for (int i = 0; i < numericUpDownBitsToGen.Value; ++i)
            {
                sb.Append(bbs.LastBit ? "1" : "0");
                bbs.Next();
            }
            watch.Start();
            labelExTime.Text = $"Execution Time: {watch.ElapsedMilliseconds} ms";
            richTextBoxStream.Text = sb.ToString();
        }

        private void rC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
