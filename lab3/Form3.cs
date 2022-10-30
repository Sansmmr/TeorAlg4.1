using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Lab1.Form1
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton4.Text = "Brute force";
            radioButton5.Text = "Divide and conquer";
            sorting1 = myArr.bruteForce;
            sorting2 = myArr.mergeInversions;
            button1.Text = "Inversions";
            chart1.Series[0].LegendText = "Brute force";
            chart1.Series[1].LegendText = "Divide and conquer";
        }
        public override void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked) sorting1?.Invoke();
            else if (radioButton5.Checked) sorting2?.Invoke();
            listBox2.Items.Clear();
            listBox2.Items.Add("Count inversions:"+myArr.countInversions.ToString());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
