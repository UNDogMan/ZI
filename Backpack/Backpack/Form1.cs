using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    public partial class Form1 : Form
    {
        private BackPackCode code;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            if(textBoxI.Text.Length == 0)
            {
                code = new BackPackCode();
            }
            else
            {
                code = new BackPackCode(int.Parse(textBoxI.Text));
            }
            richTextBoxInfo.Text = code.ToString();
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(richTextBoxRaw.Text);
            BigInteger[] nums = code.Encode(bytes);
            StringBuilder sb = new StringBuilder();
            foreach(var num in nums)
            {
                sb.Append(num).Append('\n');
            }
            richTextBoxCode.Text = sb.ToString();
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            BigInteger[] nums = richTextBoxCode.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => BigInteger.Parse(x)).ToArray();
            byte[] bytes = code.Decode(nums);
            richTextBoxDecode.Text = Encoding.ASCII.GetString(bytes);
        }
    }
}
