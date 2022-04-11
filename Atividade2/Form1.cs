using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 - num2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 * num2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                if (num2 == 0)
                    MessageBox.Show("Não é possível dividir por zero");
                else
                {
                    resultado = num1 / num2;
                    txtResult.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out num1))
            {
                 MessageBox.Show("Número 1 inválido");
            }

        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Número 2 inválido");
            }

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && (double.TryParse(txtNum2.Text, out num2)))
            {
                resultado = num1 + num2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
