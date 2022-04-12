using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ladoA;
        double ladoB;
        double ladoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out ladoA) && double.TryParse(txt2.Text, out ladoB) && double.TryParse(txt3.Text, out ladoC))
            {
                if ((ladoA < (ladoB + ladoC)) && (ladoA > Math.Abs(ladoB - ladoC)) && (ladoB < (ladoA + ladoC)) && (ladoB > Math.Abs(ladoA - ladoC)) && (ladoC < (ladoA + ladoB)) && (ladoC > Math.Abs(ladoA - ladoB)))
                {
                    if ((ladoA == ladoB) && (ladoB == ladoC) && (ladoC == ladoA))
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else if ((ladoA == ladoB) || (ladoB == ladoC) || (ladoC == ladoA))
                    {
                        MessageBox.Show("Triângulo Isóceles");
                    }
                    else 
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
