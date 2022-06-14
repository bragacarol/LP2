using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=APOLO;Initial Catalog=LP2;Persist Security Info=True;User ID=BD2121048; PASSWORD=Bobito123");

                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            } 
        }

        private void cadastroFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["cadastroFerramentas"];

            if (fc != null)
                fc.Close();

            cadastroFerramentas frm1 = new cadastroFerramentas();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["sobre"];

            if (fc != null)
                fc.Close();

            sobre frm1 = new sobre();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
