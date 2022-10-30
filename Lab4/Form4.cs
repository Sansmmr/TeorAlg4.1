using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Lab1.Form1
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton4.Text = "Quick sort";
            radioButton5.Text = "Random quick sort";
            sorting1 = myArr.quickSortRun;
            sorting2 = myArr.quickSortRandRun;
            chart1.Series[0].LegendText = "Quick sort";
            chart1.Series[1].LegendText = "Random quick sort";
        }
    }
}
