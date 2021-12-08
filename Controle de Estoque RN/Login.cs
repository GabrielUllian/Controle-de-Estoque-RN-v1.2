using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque_RN
{
    public partial class Login : Form
    {

        public Login()
        {

            InitializeComponent();
        }

        public void btnLogar_Click(object sender, EventArgs e)
        {
            if ((txtBLogin.Text == "Admin") && (txtBSenha.Text == "Admin") || (txtBLogin.Text == "Gabriel") && (txtBSenha.Text == "Gabriel"))
            {
                this.Hide();
                Form1 startPainel = new Form1();
                startPainel.Show();
            }
            else 
            {
                MessageBox.Show("Usuário e/ou Senha Incorretos.");
            }

        }
        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
