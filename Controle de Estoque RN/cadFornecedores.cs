using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Controle_de_Estoque_RN
{
    public partial class cadFornecedores : Form
    {

        public cadFornecedores()
        {
            InitializeComponent();
        }

        private void cadFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mydbDataSet.fornecedores);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadForCodFor_Click(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.Fill(this.mydbDataSet.fornecedores);
            if ((txtCadForCep.Text != "") && (txtCadForCNPJ.Text != "") && (txtCadForEnd.Text != "") && (txtCadForIden.Text != "") && (txtCadForMail.Text != "") && (txtCadForTel.Text != ""))
            {

                MySqlConnection conn = new MySqlConnection();
                MySqlCommand comando = new MySqlCommand();

                conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
                conn.Open();


                comando.Connection = conn;
                comando.CommandText = "insert into fornecedores(identificacao,cnpj,telefone,email,endereco,cep) values (@identificacao,@cnpj,@telefone,@email,@endereco,@cep)";
                comando.Parameters.AddWithValue("@identificacao", txtCadForIden.Text);
                comando.Parameters.AddWithValue("@cnpj", txtCadForCNPJ.Text);
                comando.Parameters.AddWithValue("@telefone", txtCadForTel.Text);
                comando.Parameters.AddWithValue("@email", txtCadForMail.Text);
                comando.Parameters.AddWithValue("@endereco", txtCadForEnd.Text);
                comando.Parameters.AddWithValue("@cep", txtCadForCep.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Cadastrado.");
                this.Close();
                cadFornecedores cadF = new cadFornecedores();
                cadF.Show();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }

        private void btnCadForExcFor_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();

            conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
            conn.Open();

            comando.Connection = conn;
            comando.CommandText = ("DELETE FROM fornecedores WHERE idFornecedores = @idFornecedores");
            comando.Parameters.Add(new MySqlParameter("@idFornecedores", Convert.ToInt32(dgvCadFor.CurrentRow.Cells[0].Value)));

            comando.ExecuteNonQuery();

            MessageBox.Show("Fornecedor Excluído.");

            conn.Close();

            this.Close();
            cadFornecedores cadF = new cadFornecedores();
            cadF.Show();
        }

        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
