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
    public partial class cadProdutos : Form
    {
        public cadProdutos()
        {
            InitializeComponent();
        }

        private void cadProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mydbDataSet1.produtos);
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mydbDataSet.fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mydbDataSet.fornecedores);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();

            conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
            conn.Open();


            comando.Connection = conn;
            comando.CommandText = "insert into produtos(descricao,preco,quantidade,unidade,idFornecedor) values (@descricao,@preco,@quantidade,@unidade,@idFornecedor)";
            comando.Parameters.AddWithValue("@descricao", txtCadProdDesc.Text);
            comando.Parameters.AddWithValue("@preco", txtCadProdPrec.Text);
            comando.Parameters.AddWithValue("@quantidade", txtCadProdQtd.Text);
            comando.Parameters.AddWithValue("@unidade", txtCadProdUni.Text);
            comando.Parameters.AddWithValue("@idFornecedor", cbCadProdFor.Text);


            comando.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Produto Adicionado.");

            this.Close();
            cadProdutos cadP = new cadProdutos();
            cadP.Show();
        }

        private void btnCadProdExc_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();

            conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
            conn.Open();

            comando.Connection = conn;
            comando.CommandText = ("DELETE FROM produtos WHERE idProdutos = @idProdutos");
            comando.Parameters.Add(new MySqlParameter("@idProdutos", Convert.ToInt32(dgvCadProd.CurrentRow.Cells[0].Value)));

            comando.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Produto Removido.");

            this.Close();
            cadProdutos cadP = new cadProdutos();
            cadP.Show();
        }
    }
}
