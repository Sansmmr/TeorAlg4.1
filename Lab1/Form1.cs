using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Arr myArr;
        public Action sorting1;
        public Action sorting2;
        public List<RadioButton> allRadioButton = new List<RadioButton>();
        public Form1()
        {
            InitializeComponent();
            myArr = new Arr();
            sorting1 = myArr.bubbleSort;
            sorting2 = myArr.insertingSort;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            myArr.size = Convert.ToInt32(textBox1.Text);
            myArr.arr = new int[myArr.size];
            myArr.A_Z();
            listBox1.Items.Clear();
            for (int i = 0; i < myArr.size; i++)
            {
                listBox1.Items.Add(myArr.arr[i].ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (var item in allRadioButton)
                {
                    item.Visible = false;
                }
                button1.Visible = false;
            }
            else
            {
                foreach (var item in allRadioButton)
                {
                    item.Visible = true;
                }
                button1.Visible = true;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            myArr.size = Convert.ToInt32(textBox1.Text);
            myArr.arr = new int[myArr.size];
            myArr.Z_A();
            listBox1.Items.Clear();
            for (int i = 0; i < myArr.size; i++)
            {
                listBox1.Items.Add(myArr.arr[i].ToString());
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            myArr.size = Convert.ToInt32(textBox1.Text);
            myArr.arr = new int[myArr.size];
            myArr.Rand();
            listBox1.Items.Clear();
            for (int i = 0; i < myArr.size; i++)
            {
                listBox1.Items.Add(myArr.arr[i].ToString());
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        public virtual void button1_Click(object sender, EventArgs e)
        {

            if (radioButton4.Checked) sorting1?.Invoke();
            else if (radioButton5.Checked) sorting2?.Invoke();

            listBox2.Items.Clear();
            for (int i = 0; i < myArr.size; i++)
            {
                listBox2.Items.Add(myArr.arr[i].ToString());
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }


        private void Sorting1()
        {
            for (int i = 10; i <3000; i += 50)
            {
                myArr.size = i;
                myArr.arr = new int[i];
                myArr.Rand();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                watch.Start();
                sorting1();
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                chart1.Series[0].Points.AddXY(i, elapsedMs);
            }
            chart1.ChartAreas[0].AxisX.Title = "Aray elements";
            chart1.ChartAreas[0].AxisY.Title = "Time";
        }
        private void Sorting2()
        {
            for (int i = 10; i < 3000; i += 50)
            {
                myArr.size = i;
                myArr.arr = new int[i];
                myArr.Rand();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                watch.Start();
                sorting2();
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                chart1.Series[1].Points.AddXY(i, elapsedMs);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorting2();
            Sorting1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allRadioButton.Add(radioButton1);
            allRadioButton.Add(radioButton2);
            allRadioButton.Add(radioButton3);
            allRadioButton.Add(radioButton4);
            allRadioButton.Add(radioButton5);
            if (textBox1.Text.Length == 0)
            {
                foreach (var item in allRadioButton)
                {
                    item.Visible = false;
                }
                button1.Visible = false;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
