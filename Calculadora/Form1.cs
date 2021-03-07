using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "0";
        }

        private void BtnN1_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "1";
        }

        private void BtnN2_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "2";
        }

        private void BtnN3_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "3";
        }

        private void BtnN4_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "4";
        }

        private void BtnN6_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "6";
        }

        private void BtnN8_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "8";
        }
    }
}
