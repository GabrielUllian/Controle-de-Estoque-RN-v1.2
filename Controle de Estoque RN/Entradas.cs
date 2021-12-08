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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }

        private void Entradas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mydbDataSet1.produtos);
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet2.entradas'. Você pode movê-la ou removê-la conforme necessário.
            this.entradasTableAdapter.Fill(this.mydbDataSet2.entradas);
        }

        private void btnEntEstAdcProd_Click(object sender, EventArgs e)
        {

            this.entradasTableAdapter.Fill(this.mydbDataSet2.entradas);
            if ((cbCadProdFor.Text != "") && (txtEntEstQtd.Text != "") && (txtEntEstPreco.Text != ""))
            {

                MySqlConnection conn = new MySqlConnection();
                MySqlCommand comando = new MySqlCommand();

                conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
                conn.Open();


                comando.Connection = conn;
                comando.CommandText = "insert into entradas(idProdutos,descricao,quantidade,preco,dataEntrada) values (@idProdutos,@descricao,@quantidade,@preco,@dataEntrada)";
                comando.Parameters.AddWithValue("@idProdutos", cbCadProdFor.Text);
                comando.Parameters.AddWithValue("@descricao", txtEntEstDet.Text);
                comando.Parameters.AddWithValue("@quantidade", txtEntEstQtd.Text);
                comando.Parameters.AddWithValue("@preco", txtEntEstPreco.Text);
                comando.Parameters.AddWithValue("@dataEntrada", DateTime.Today);

                comando.ExecuteNonQuery();

                MessageBox.Show("Entrada Cadastrada.");
                this.Close();
                Entradas inEst = new Entradas();
                inEst.Show();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnEntEstExc_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();

            conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
            conn.Open();

            comando.Connection = conn;
            comando.CommandText = ("DELETE FROM entradas WHERE idEntradas = @idEntradas");
            comando.Parameters.Add(new MySqlParameter("@idEntradas", Convert.ToInt32(dgvEntEst.CurrentRow.Cells[0].Value)));

            comando.ExecuteNonQuery();

            MessageBox.Show("Entrada Excluída.");

            conn.Close();

            this.Close();
            Entradas inEst = new Entradas();
            inEst.Show();
        }

        private void txtEntEstDet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEntEstDet_Click(object sender, EventArgs e)
        {

        }
    }
}
