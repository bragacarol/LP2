using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ir em project -> add Reference e habilitar a opção Microsoft.VisualBasic depois usar essa declaração para usar o Inputbox 
using Microsoft.VisualBasic;

namespace Atividade_9
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarando um vetor
            int[] vetor = new int[20];
            string auxiliar = "";

            //estrutura: for(declara a variável; condição para entrar nele; o que ele vai fazer) 
            for (var i = 0; i < 20; i++)
            {
                //estrutura padrão para usar o Inputbox
                auxiliar = Interaction.InputBox("Digite um número", "Entrada de dados");
                if(auxiliar == "")
                {
                    break;
                }
                if(!int.TryParse(auxiliar, out vetor[i]))
                {
                    //comando: mbox tab tab
                    MessageBox.Show("Número inválido");2
                    i--;
                }
            }
            
            //invertendo a ordem do vetor, não posso exibir essa variável vetor no mbox pois ele só exibe strings e vetor é um array de int
            Array.Reverse(vetor);
            auxiliar = "";

            //aqui estou pegando cada item do vetor e armazenando em uma variável a lista anterior + o item atual pulando uma linha
            foreach(int inteiro in vetor)
            {
                auxiliar = auxiliar + "\n" + inteiro;
            }

            MessageBox.Show(auxiliar);
        }
    }
}
