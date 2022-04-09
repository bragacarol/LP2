using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_imc
{
    public partial class Form1 : Form
    {
        double peso;
        double altura;
        double imc;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(maskedTextBox1.Text, out peso) && double.TryParse(maskedTextBox2.Text, out altura))
            {
                imc = peso / (altura * altura);
                if(imc < 18.5)
                {
                    MessageBox.Show("O seu imc é "+imc.ToString()+". Sua classificação é Magreza");
                }
                else if(imc <= 24.9)
                {
                    MessageBox.Show("O seu imc é " + imc.ToString() + ". Sua classificação é Normal");
                }
                else if (imc <= 29.9)
                {
                    MessageBox.Show("O seu imc é " + imc.ToString() + ". Sua classificação é Sobrepeso");
                }
                else if (imc <= 39.9)
                {
                    MessageBox.Show("O seu imc é " + imc.ToString() + ". Sua classificação é Obesidade");
                }
                else if (imc > 40)
                {
                    MessageBox.Show("O seu imc é " + imc.ToString() + ". Sua classificação é Obesidade Grave");
                }
            }
        }
    }
}
