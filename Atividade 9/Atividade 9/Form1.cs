using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //estrutura padrão para abrir o exercício quando clicar no menu

            Form fc = Application.OpenForms["Exercicio1"];
            if (fc != null)
                fc.Close();

            Exercicio1 objFrm = new Exercicio1();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio5"];
            if (fc != null)
                fc.Close();

            Exercicio5 objFrm = new Exercicio5();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }
    }
}
