using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public class Bounds
        {
            public int n;
            public int m;

            public override string ToString()
            {
                return $"{n}x{m}";
            }
        }



        private int size;
        private string msg;
        private Bounds bounds;
        private string exMsg;
        private string errMsg;

        private bool go;
        private List<int> errList;
        private int errCount;
        private int ok;
        private int err;
        private int no;

        private Matrix<double> X;

        public Form1()
        {
            InitializeComponent();

            comboBoxErrCount.Items.AddRange(Enumerable.Range(0, 4).Select(x => (object)x).ToArray());
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '1' || e.KeyChar == '0' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            comboBoxBounds.Items.Clear();
            size = textBoxInput.Text.Length;
            msg = textBoxInput.Text;
            for(int i = 1; i <= size; i++)
            {
                if(size % i == 0)
                {
                    comboBoxBounds.Items.Add(new Bounds { n = i, m = size / i });
                }
            }
        }

        private string GetStringFromMatrix(Matrix<double> matrix)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int n = matrix.RowCount;
            int m = matrix.ColumnCount;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < m - 1; j++)
                {
                    stringBuilder.Append((int)matrix[i, j]);
                }
            }
            for(int i = 0; i < n - 1; i++)
            {
                stringBuilder.Append((int)matrix.Column(m - 1)[i]);
            }
            for(int j = 0; j < m - 1; j++)
            {
                stringBuilder.Append((int)matrix.Row(n - 1)[j]);
            }
            stringBuilder.Append((int)matrix[n - 1, m - 1]);
            return stringBuilder.ToString();
        }
        private Matrix<double> BuildMatrixFromString(string msg, Bounds bounds)
        {
            int n = bounds.n;
            int m = bounds.m;

            double[,] arr = new double[n + 1, m + 1];
            for (int i = 0; i < size; i++)
            {
                arr[i / m, i % m] = msg[i] == '1' ? 1 : 0;
            }
            Matrix<double> X = DenseMatrix.OfArray(arr);
            for (int i = 0; i <= n; i++)
            {
                int sum = 0;
                for (int j = 0; j <= m; j++)
                {
                    sum += (int)X[i, j];
                }
                X[i, m] = sum % 2;
            }
            for (int j = 0; j <= m; j++)
            {
                int sum = 0;
                for (int i = 0; i <= n; i++)
                {
                    sum += (int)X[i, j];
                }
                X[n, j] = sum % 2;
            }
            return X;
        }

        private string MakeErrors(string msg, List<int> errs)
        {
            char[] parseChars = msg.ToArray();
            foreach(var i in errs)
            {
                parseChars[i - 1] = parseChars[i - 1] == '0' ? '1' : '0'; 
            }
            return new string(parseChars);
        }

        private string StrXor(string a, string b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    stringBuilder.Append('0');
                else
                    stringBuilder.Append('1');
            }
            return stringBuilder.ToString();
        }
        private void buttonGen_Click(object sender, EventArgs e)
        {
            bounds = (Bounds)comboBoxBounds.SelectedItem;
            msg = textBoxInput.Text;
            X = BuildMatrixFromString(msg, bounds);
            richTextBoxOut.Text = X.ToString().DelLine();
            exMsg = GetStringFromMatrix(X);
            richTextBoxEW.Text = exMsg;
            richTextBoxEW.Select(0, size);
            richTextBoxEW.SelectionFont = new Font(richTextBoxEW.Font, FontStyle.Bold);

            go = false;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (comboBoxErrCount.SelectedItem is null)
                return;
            errCount = (int)comboBoxErrCount.SelectedItem;
            errList = new List<int>(Enumerable.Range(1, errCount));
            textBoxErrList.Text = errList.PrintLine();
            errMsg = MakeErrors(exMsg, errList);
            textBoxErrStr.Text = errMsg;
            TrySolve();
            go = true;

            ok = 0;
            err = 0;
            no = 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (go)
            {
                Sets.NextSet(errList, size, errCount);
                textBoxErrList.Text = errList.PrintLine();
                errMsg = MakeErrors(exMsg, errList);
                textBoxErrStr.Text = errMsg;
                TrySolve();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (go)
            {
                while (Sets.NextSet(errList, size + bounds.m + bounds.n + 1, errCount)) ;
                textBoxErrList.Text = errList.PrintLine();
                errMsg = MakeErrors(exMsg, errList);
                textBoxErrStr.Text = errMsg;
                TrySolve();
            }
        }

        void UpdateNum()
        {
            textBoxOk.Text = ok.ToString();
            textBoxNo.Text = no.ToString();
            textBoxErr.Text = err.ToString();
        }

        private void TrySolve()
        {
            Matrix<double> matrix = BuildMatrixFromString(errMsg, bounds);
            richTextBoxIncome.Text = matrix.ToString().DelLine();
            string nstr = GetStringFromMatrix(matrix);
            textBoxCh.Text = errMsg.Remove(0, size);
            textBoxChNew.Text = nstr.Remove(0, size);
            textBoxS.Text = StrXor(textBoxCh.Text, textBoxChNew.Text);

            UpdateNum();
        }
    }
}
