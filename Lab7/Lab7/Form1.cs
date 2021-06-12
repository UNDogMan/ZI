using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private int blockSize;
        private int columnCount;
        private int errBlockSize;

        private string message;
        private string codedMessage;
        private string shuffedMessage;
        private string errString;
        private string deshuffedMessage;
        private string decodedMessage;
        private string incomeMessage;

        Matrix<double> hMatrix;

        private Random random = new Random();

        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public int VectorWeigh(Vector<double> vs)
        {
            int ans = 0;
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i] == 1) ans++;
            }
            return ans;
        }

        private Matrix<double> CreateHForHeminng(int k)
        {
            int r = (int)Math.Ceiling(Math.Log(k, 2) + 1) + 1;

            double[,] g = new double[r, k];
            double[,] i = new double[r, r];

            for (int ii = 0; ii < r; ii++)
            {
                i[ii, ii] = 1;
            }

            int f = 1;
            int count1 = 0;
            for (int j = 0; j < k; j++)
            {
                while (Aditions.IsPowerOfTwo((ulong)f)) f++;
                int d = f;

                int ff = 0;
                while (d > 0)
                {
                    g[ff, j] = d % 2;
                    if (d % 2 == 1) count1++;
                    d /= 2;
                    ff++;
                }
                g[r - 1, j] = count1 % 2 == 0 ? 1 : 0;
                f++;
            }

            return DenseMatrix.OfArray(g).Append(DenseMatrix.OfArray(i));
        }

        private Vector<double> encodeByHeming(Vector<double> msg, Matrix<double> H)
        {
            int k = H.ColumnCount - H.RowCount;
            int r = (int)Math.Ceiling(Math.Log(k, 2) + 1) + 1;
            var xr = new double[r];
            for (int ii = 0; ii < r; ii++)
            {
                for (int j = 0; j < k; j++)
                {
                    xr[ii] += (msg[j] == 1.0f ? 1 : 0) * H[ii, j];
                }
                xr[ii] %= 2;
            }

            Matrix<double> Xr = Matrix<double>.Build.Dense(1, r, (ii, jj) => (double)xr[jj]);
            Matrix<double> Xk = Matrix<double>.Build.Dense(1, msg.Count, (ii, jj) => msg[jj] == 1.0f ? 1 : 0);
            Matrix<double> Xn = DenseMatrix.OfMatrix(Xk).Append(Xr);
            return Xn.Row(0);
        }  

        private (Vector<double>, bool) decodeByHeming(Vector<double> msg, Matrix<double> H)
        {
            bool ok = true;
            var Yn = msg.ToRowMatrix();
            var S = H * Yn.Transpose();
            bool flag = false;
            for (int i = 0; i < S.RowCount; i++)
            {
                S[i, 0] %= 2;
                flag = flag || S[i, 0] != 0;
            }
            if (flag && VectorWeigh(S.Column(0)) % 2 == 0)
                ok = false;

            var En = Matrix<double>.Build.Dense(1, H.ColumnCount, 0);

            if (flag)
            {
                for (int i = 0; i < H.ColumnCount; i++)
                {
                    if (H.Column(i).Equals(S.Column(0)))
                    {
                        En[0, i] = 1;
                    }
                }
            }
            var Y_n = DenseMatrix.OfMatrix(Yn) + En;
            for (int i = 0; i < Y_n.ColumnCount; i++)
            {
                Y_n[0, i] %= 2;
            }

            return (Y_n.Row(0), ok);
        }

        private string blockShuffele(string str, int columnCount)
        {
            string[] shuffedArr = Aditions.FullSplit(str, columnCount).ToArray();
            List<char> shuffedList = new List<char>();
            for (int i = 0; i < shuffedArr[0].Length; i++)
            {
                for (int j = 0; j < shuffedArr.Length; j++)
                    if (i < shuffedArr[j].Length)
                        shuffedList.Add(shuffedArr[j][i]);
            }
            return new string(shuffedList.ToArray());
        }

        private string deblockShuffle(string str, int columnCount)
        {
            int full = str.Length / columnCount;
            int low = str.Length % columnCount;

            int n = low == 0 ? full : full + 1;
            List<List<char>> llChar = new List<List<char>>(n);
            for (int i = 0; i < n; i++)
            {
                llChar.Add(new List<char>());
            }
            int kk = 0;
            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < low || j < n - 1 || low == 0 & j < n) {
                        llChar[j].Add(str[kk]);
                        kk += 1;
                    }
                }
            }

            return String.Join("", llChar.Select(i => new string(i.ToArray())));
        }

        private (int, string) genErrors(int blockSize, string str)
        {
            int pos = random.Next(0, str.Length - blockSize - 1);
            char[] s = str.ToCharArray();
            for (int i = 0; i < blockSize; i++)
                s[i + pos] = s[i + pos] == '1' ? '0' : '1';
            str.Replace(str, new string(s));
            return (pos, new string(s));
        }

        public Form1()
        {
            InitializeComponent();
            Enumerable.Range(3, 5).ToList().ForEach(i => comboBoxBlockSize.Items.Add(i));
            comboBoxBlockSize.SelectedIndex = 0;
            Enumerable.Range(2, 13).ToList().ForEach(i => comboBoxColumnCount.Items.Add(i));
            comboBoxColumnCount.SelectedIndex = 0;
            Enumerable.Range(3, 5).Concat(new int[] { 0}).ToList().ForEach(i => comboBoxErrBlockSize.Items.Add(i));
            comboBoxErrBlockSize.SelectedIndex = 0;
        }

        private void comboBoxBlockSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.blockSize = (int)comboBoxBlockSize.SelectedItem;
            hMatrix = CreateHForHeminng(blockSize);
            textBoxMessage_TextChanged(null, null);
        }
        private void comboBoxColumnCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.columnCount = (int)comboBoxColumnCount.SelectedItem;
            textBoxMessage_TextChanged(null, null);
        }

        private void comboBoxErrBlockSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errBlockSize = (int)comboBoxErrBlockSize.SelectedItem;
            textBoxMessage_TextChanged(null, null);
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '0' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMessage.TextLength > 0)
            {
                textBoxByBlock.Text = String.Join(" ", Aditions.SplitAndComplite(textBoxMessage.Text, this.blockSize));
                message = Aditions.Complite(textBoxMessage.Text, this.blockSize);
                codedMessage = String.Join("", Aditions.SplitAndComplite(textBoxMessage.Text, this.blockSize).Select(i => encodeByHeming(i.ToVectorDouble(), this.hMatrix).ToString().DelLine())).Replace("\n", "").Replace("\r", "");
                textBoxMsgCoded.Text = String.Join(" ", Aditions.SplitAndComplite(textBoxMessage.Text, this.blockSize).Select(i => encodeByHeming(i.ToVectorDouble(), this.hMatrix).ToString().DelLine()));
                
                richTextBoxShiffMatrix.Text = string.Join("\n", Aditions.FullSplit(codedMessage, columnCount).ToArray());
                shuffedMessage = blockShuffele(codedMessage, columnCount);
                textBoxShuffed.Text = shuffedMessage;

                errString = (string)shuffedMessage.Clone(); 
                int errPos = 0;
                (errPos, errString) = genErrors(errBlockSize, errString);
                richTextBoxErrStr.Text = errString;
                richTextBoxErrStr.Select(errPos, errBlockSize);
                richTextBoxErrStr.SelectionFont = new Font(richTextBoxErrStr.Font, FontStyle.Bold);

                deshuffedMessage = deblockShuffle(errString, columnCount);
                richTextBoxShuffleMatrixOut.Text = string.Join("\n", Aditions.FullSplit(errString, columnCount).ToArray());
                textBoxDesheffed.Text = deshuffedMessage;

                var decode = Aditions.Split(deshuffedMessage, hMatrix.ColumnCount).Select(i => decodeByHeming(i.ToVectorDouble(), hMatrix));
                bool ok = true;
                decodedMessage = "";
                incomeMessage = "";
                foreach(var i in decode)
                {
                    ok = ok & i.Item2;
                    string str = i.Item1.ToString().DelLine().Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    decodedMessage = decodedMessage + str + " ";
                    incomeMessage = incomeMessage + str.Substring(0, blockSize) + " ";
                }

                textBoxDecoded.Text = decodedMessage;
                textBoxIncome.Text = incomeMessage;
                textBoxOk.Text = $"{ok}  {String.Compare(message, incomeMessage.Replace(" ",""))}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
