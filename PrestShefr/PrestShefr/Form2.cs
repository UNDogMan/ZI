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
    public partial class Form2 : Form
    {
        private BindingSource bindingSource;
        public Form2()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            bindingSource.DataSource = AlphabelLoader.pairs;
            comboBoxPairs.DataSource = bindingSource;
            AlphabelLoader.pairs.CollectionChanged += Pairs_CollectionChanged;
        }

        private void Pairs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            bindingSource.ResetBindings(false);
        }

        private void CaesarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.form2.Hide();
            Program.form1.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAlphabet editAlphabet = new EditAlphabet();
            editAlphabet.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            TrisemusCode code = new TrisemusCode(AlphabelLoader.alphabet, this.textBoxK.Text, (Pair<int>)this.comboBoxPairs.SelectedItem);
            this.richTextBox2.Text = new string(this.richTextBox1.Text.Select(x => x = code.Code(x)).ToArray());
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            TrisemusCode code = new TrisemusCode(AlphabelLoader.alphabet, this.textBoxK.Text, (Pair<int>)this.comboBoxPairs.SelectedItem);
            this.richTextBox1.Text = new string(this.richTextBox2.Text.Select(x => x = code.Decode(x)).ToArray());
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
