using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    { 
        Double re = 0;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            re = Double.Parse(txt1.Text) / Double.Parse(txt2.Text);
            result.Text = re .ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            re = Double.Parse(txt1.Text) + Double.Parse(txt2.Text);
            result.Text = re.ToString();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            re = Double.Parse(txt1.Text) - Double.Parse(txt2.Text);
            result.Text = re.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            re = Double.Parse(txt1.Text) * Double.Parse(txt2.Text);
            result.Text = re.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            result.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            result.Clear();
        }
    }
}

