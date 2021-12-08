using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySqlX;

namespace Controle_de_Estoque_RN
{
    public partial class Form1 : Form
    {
        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnTrocaUsuario_Click(object sender, EventArgs e)
        {   
            Login genU = new Login();
            genU.Show();
            this.Hide();
        }

        public void btnCadFornece_Click(object sender, EventArgs e)
        {
            cadFornecedores cadF = new cadFornecedores();
            cadF.Show();
        }

        public void btnCadprod_Click(object sender, EventArgs e)
        {
            cadProdutos cadP = new cadProdutos();
            cadP.Show();
        }

        public void btnImputEst_Click(object sender, EventArgs e)
        {
            Entradas inEst = new Entradas();
            inEst.Show();
        }

        public void btnOutputEst_Click(object sender, EventArgs e)
        {
            Saidas inEst = new Saidas();
            inEst.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
