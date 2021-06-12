using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestShefr
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            if (dialog.ShowDialog() == DialogResult.OK)
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
            SnakePermutation permutation = new SnakePermutation((int)kNumericUpDown.Value);
            this.richTextBox2.Text = permutation.Code(richTextBox1.Text);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            SnakePermutation permutation = new SnakePermutation((int)kNumericUpDown.Value);
            this.richTextBox1.Text = permutation.Decode(richTextBox2.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAlphabet editAlphabet = new EditAlphabet();
            editAlphabet.ShowDialog();
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

        private void buttonOpenTextMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBoxMP.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void buttonOpenCTextMP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBoxCMP.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void buttonSaveTextMP_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.richTextBoxMP.Text);
            }
        }

        private void buttonSaveCTextMP_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.richTextBoxCMP.Text);
            }
        }

        private void buttonTextMPStat_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(new string(AlphabelLoader.alphabet), this.richTextBoxMP.Text);
            histogram.Show();
        }

        private void buttonCTextMPStat_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(new string(AlphabelLoader.alphabet), this.richTextBoxCMP.Text);
            histogram.Show();
        }

        private void buttonCodeMP_Click(object sender, EventArgs e)
        {
            MultiPermutation permutation = new MultiPermutation(textBoxKey1MP.Text, textBoxKey2MP.Text);
            this.richTextBoxCMP.Text = permutation.Code(richTextBoxMP.Text);
        }

        private void buttonDecodeMP_Click(object sender, EventArgs e)
        {
            MultiPermutation permutation = new MultiPermutation(textBoxKey1MP.Text, textBoxKey2MP.Text);
            this.richTextBoxMP.Text = permutation.Decode(richTextBoxCMP.Text);
        }
    }
}
