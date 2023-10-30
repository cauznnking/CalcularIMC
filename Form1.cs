using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double peso, alt, result;

                peso = double.Parse(TxbNum1.Text);
                alt = double.Parse(txbNum2.Text);
                result = peso/ (alt * alt);

                LblResultado.Text = result.ToString();

                if (result <= 18.5)
                {
                    LblEstado.Text = " Abaixo do peso ";
                }
                else if (result > 18.6 && result <= 24.9)
                {
                    LblEstado.Text = " Peso ideal ";
                }
                else if (result > 24.9 && result <= 29.9) 
                {
                    LblEstado.Text = " Levemente acima do peso ";
                }
                else if (result > 30.0 && result <= 34.9 )
                {
                    LblEstado.Text = " Obesidade grau 1 ";
                }
                else if (result > 35.0 && result <= 39.9)
                {
                    LblEstado.Text = " Obesidade grau 2 (Severa) ";
                }
                else 
                {
                    LblEstado.Text = " Obesidaded 3 (Morbida) ";
                }

                if (alt <= 0 || peso <= 0)
                {
                    TxbNum1.Clear();
                    txbNum2.Clear();
                    LblEstado.Text = "";
                    LblResultado.Text = "";
                    MessageBox.Show("Altura ou Peso Inválidos!");
                }

            }
            catch 
            {
                MessageBox.Show("Dados nao correspodentes !!!");
                TxbNum1.Clear();
                txbNum2.Clear();
                LblEstado.Text = "";
                LblResultado.Text = "";
            }

        }

        private void LblPeso_Click(object sender, EventArgs e)
        {

        }
    }
}
