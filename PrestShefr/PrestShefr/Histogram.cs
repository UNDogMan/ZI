using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrestShefr
{
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }
        public Histogram(string alph, string text)
        {
            InitializeComponent();
            DrawHistogram(alph, text);
        }

        public void DrawHistogram(string alph, string text)
        {
            double count = text.Length;
            for (int i = 0; i < alph.Length; i++)
            {
                chartMain.Series[0].Points.AddXY(alph[i].ToString(), (double)text.Count(c => c == alph[i]) / count);
            }
            chartMain.ChartAreas[0].AxisX.Interval = 1;
            chartMain.ChartAreas[0].AxisY.Interval = 0.05;
            chartMain.Legends[0].Docking = Docking.Bottom;
            chartMain.Legends[0].Enabled = false;
        }
    }
}
