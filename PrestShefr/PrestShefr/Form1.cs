using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrestShefr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yxkModNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trisemusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form1.Hide();
            Program.form2.Show();
        }

        private void buttonOpenText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void buttonOpenCodeText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox2.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.richTextBox1.Text);
            }
        }

        private void buttonSaveCodeText_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.richTextBox2.Text);
            }
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            CaesarCode code = new CaesarCode((int)this.kNumericUpDown.Value, AlphabelLoader.alphabet);
            this.richTextBox2.Text = new string(this.richTextBox1.Text.Select(x => x = code.Code(x)).ToArray());
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            CaesarCode code = new CaesarCode((int)this.kNumericUpDown.Value, AlphabelLoader.alphabet);
            this.richTextBox1.Text = new string(this.richTextBox2.Text.Select(x => x = code.Decode(x)).ToArray());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAlphabet editAlphabet = new EditAlphabet();
            editAlphabet.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonStatL_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(new string(AlphabelLoader.alphabet), this.richTextBox1.Text);
            histogram.Show();
        }

        private void buttonStatR_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(new string(AlphabelLoader.alphabet), this.richTextBox2.Text);
            histogram.Show();
        }
    }
}
