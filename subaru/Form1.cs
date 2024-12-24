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

namespace subaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        ArrayList liste = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            liste.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
            }
        }

        ArrayList csayi = new ArrayList();
        ArrayList tsayi = new ArrayList();
        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox2.Text);
            for (int i = 0; i <= sayi; i++)
            {
                if (i%2==0)
                {
                    csayi.Add(i);
                }
                else
                {
                    tsayi.Add(i);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in csayi)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in tsayi)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {          
            int s = listBox1.SelectedIndex;
            liste.Insert(s,textBox1.Text);
            Listele();

        }

        public void Listele() 
        {
            listBox1.Items.Clear();
            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string yazilan = textBox1.Text;
            liste.Remove(yazilan);
            Listele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            liste.RemoveAt(secilen);
            Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
