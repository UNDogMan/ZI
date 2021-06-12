using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGCDCalc_Click(object sender, EventArgs e)
        {
            int[] str = textBoxGCDNums.Text.Split(" ,;.".ToCharArray()).Select(x => int.Parse(x)).ToArray();
            textBoxGCDans.Text = Utils.gcd(str).ToString();
        }

        private void buttonSCalc_Click(object sender, EventArgs e)
        {
            uint n = uint.Parse(textBoxN.Text);
            uint m = uint.Parse(textBoxM.Text);

            List<uint> ans = Utils.SimplNums(2u, n);
            richTextBox1.Text += "Count " + ans.Count.ToString() + '\n';
            richTextBox1.Text += string.Join(" ", ans.Select(x => x.ToString()));

            ans = Utils.SimplNums(m, n);
            richTextBox2.Text += "Count " + ans.Count.ToString() + '\n';
            richTextBox2.Text += string.Join(" ", ans.Select(x => x.ToString()));
        }
    }
}
