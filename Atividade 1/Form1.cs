using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Valor de raio inválido");
            }
            else if (raio <= 0)
            {
                MessageBox.Show("Valor de raio deve ser maior que zero");
            }
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                 MessageBox.Show("Valor de altura inválido");
            }
            else if (altura <= 0)
            {
                 MessageBox.Show("Valor de altura deve ser maior que zero");
            }
            else
            {
                 volume = Math.PI * Math.Pow(raio, 2) * altura;
                 txtVolume.Text = volume.ToString("N2");
            }
            }
        }
}
