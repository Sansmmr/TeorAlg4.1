using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Lab1.Form1
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton4.Text = "Merge sort";
            sorting1 = myArr.runMerge;
            sorting2 = myArr.insertingSort;
            chart1.Series[0].LegendText= "Merge sort";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
