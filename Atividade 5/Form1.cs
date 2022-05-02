using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_5
{
    public partial class Form1 : Form
    {
        string sexo, filhos, casado;

        double salBruto, salLiquido, AliqIRPF, AliqINSS, salFamilia, numFilhos;

        private void mskbxSalario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!double.TryParse(mskbxSalario.Text, out salBruto))
            {
                MessageBox.Show("Salário inválido");
                mskbxSalario.Focus();
            }
            else if (salBruto <= 0)
            {
                MessageBox.Show("Salário inválido");
                mskbxSalario.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxFilhos.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbxNomeFunc_TextChanged(object sender, EventArgs e)
        {
            if (txtbxNomeFunc.Text == "")
            {
                MessageBox.Show("Nome inválido!");
                txtbxNomeFunc.Focus();
            }
            foreach (char c in txtbxNomeFunc.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Digite somente letras");
                    break;
                }
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            double.TryParse(cbxFilhos.Text, out numFilhos);

            if (!double.TryParse(mskbxSalario.Text, out salBruto))
                MessageBox.Show("Salário inválido");

            else if (salBruto <= 0)
                MessageBox.Show("Salário inválido");

            else if (salBruto <= 800.47)
            {
                txtINSS.Text = "7,65%";
                AliqINSS = 0.0765 * salBruto;
                txtDescINSS.Text = AliqINSS.ToString();
            }
            else if (salBruto <= 1050)
            {
                txtINSS.Text = "8,65%";
                AliqINSS = 0.0865 * salBruto;
                txtDescINSS.Text = AliqINSS.ToString();
            }
            else if (salBruto <= 1400.77)
            {
                txtINSS.Text = "9%";
                AliqINSS = 0.09 * salBruto;
                txtDescINSS.Text = AliqINSS.ToString();
            }
            else if (salBruto <= 2801.56)
            {
                txtINSS.Text = "11%";
                AliqINSS = 0.11 * salBruto;
                txtDescINSS.Text = AliqINSS.ToString();
            }
            else if (salBruto > 2801.56)
            {
                txtINSS.Text = "Teto";
                AliqINSS = 308.17;
                txtDescINSS.Text = AliqINSS.ToString();
            }

            if (salBruto <= 1257)
            {
                txtDescIRPF.Text = AliqIRPF.ToString();
                AliqIRPF = 0;
                txtIRPF.Text = "Isento";
            }
            else if (salBruto <= 2512.08)
            {
                txtDescIRPF.Text = AliqIRPF.ToString();
                AliqIRPF = salBruto * 0.15;
                txtIRPF.Text = "15%";
            }
            else
            {
                txtDescIRPF.Text = AliqIRPF.ToString();
                AliqIRPF = salBruto * 0.275;
                txtIRPF.Text = "27,5%";
            }

            if (salBruto <= 435.52)
            {
                salFamilia = 22.33 * numFilhos;
                txtSalFam.Text = salFamilia.ToString();
            }

            else if (salBruto <= 654.61)
            {
                salFamilia = 15.74 * numFilhos;
                txtSalFam.Text = salFamilia.ToString();
            }
            else
            {
                salFamilia = 0 * numFilhos;
                txtSalFam.Text = salFamilia.ToString();
            }

            salLiquido = salBruto - AliqINSS - AliqIRPF + salFamilia;

            txtSalLiq.Text = salLiquido.ToString();

            if (rbtnFem.Checked)
                sexo = " da Sra. ";
            else
                sexo = " do Sr. ";

            if (chkbxCasado.Checked && rbtnFem.Checked)
            {
                casado = " casada";
            }
            else if (!chkbxCasado.Checked && rbtnFem.Checked)
                casado = " solteira";
            else if (chkbxCasado.Checked && rbtnMasc.Checked)
                casado = " casado";
            else
                casado = " solteiro";

            if (numFilhos == 0 || cbxFilhos.Text == "")
                filhos = " não possui filhos ";
            else if (numFilhos > 1)
                filhos = " possui " + numFilhos + " filhos ";
            else
                filhos = " possui 1 filho ";

            lblMensagem.Text = "Os descontos do salário" + sexo + txtbxNomeFunc.Text + ", que é" + casado + ", e que" + filhos + "são:";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbxNomeFunc.Clear();
            txtINSS.Clear();
            mskbxSalario.Clear();
            cbxFilhos.Text = "0";
            txtINSS.Clear();
            txtIRPF.Clear();
            txtDescINSS.Clear();
            txtSalFam.Clear();
            txtSalLiq.Clear();
            lblMensagem.Text = "";
            chkbxCasado.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
