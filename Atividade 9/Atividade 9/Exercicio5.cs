using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade_9
{
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //declarando a variável tipo matriz que vai ter x e y ou seja, 2 dimensões
            double[,] matrizNotas = new double[20, 3];
            string auxiliar;
            double media = 0;

            //pegando aluno por aluno
            for(var i = 0; i < 20; i++)
            {

                //zerando a media para calcular do próximo aluno
                media = 0;

                //pegando cada nota daquele aluno do for anterior
                for (var j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota", "Entrada das notas");

                    //fazendo a validação se o valor inserido é double, se for ele vai ser inserido em matrizNotas
                    if(double.TryParse(auxiliar, out matrizNotas[i,j]))
                    {
                        //validando se a nota é inválida
                        if((matrizNotas[i,j] <= 0) || (matrizNotas[i,j] > 10))
                        {
                            MessageBox.Show("Nota inválida");

                            //decrementa o j que é a nota pra que ele volte na mesma nota, pois ela estava inválida
                            j--;
                        } 
                        
                        //deu certo a validação então soma as médias
                        else
                        {
                            //somando a nota atual com a nota anterior
                            media += matrizNotas[i, j];
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }
                }

                media = media / 3;

                //exibindo no list box as notas por aluno, estamos pegando o aluno atual do for e somando 1 para que fique melhor de entender pelo usuario
                lstNotas.Items.Add("Aluno: " + (i+1) + " Média: " + media.ToString("N2"));
            }
        }

        private void lstNotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
