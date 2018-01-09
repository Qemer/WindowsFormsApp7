using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            label1.Text = listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox2.Text);
            label1.Text = listBox1.Items.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar&&textBox1.Text.Length!=0)
          
            {
                listBox1.Items.Add(textBox1.Text);
                label1.Text = listBox1.Items.Count.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                listBox1.Items.Remove(textBox2.Text);
                label1.Text = listBox1.Items.Count.ToString();
            }
        }

        private void sort(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}

