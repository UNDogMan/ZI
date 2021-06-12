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
    public partial class EditAlphabet : Form
    {
        public EditAlphabet()
        {
            InitializeComponent();
            this.richTextBoxAlphabet.Text = new String(AlphabelLoader.alphabet);
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Alphabet.txt", richTextBoxAlphabet.Text);
            AlphabelLoader.Reload();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
