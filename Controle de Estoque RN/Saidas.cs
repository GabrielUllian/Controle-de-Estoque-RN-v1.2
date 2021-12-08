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
    public partial class Saidas : Form
    {
        public Saidas()
        {
            InitializeComponent();
        }

        private void Saidas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet11.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter2.Fill(this.mydbDataSet11.produtos);
            // TODO: esta linha de código carrega dados na tabela 'mydbDataSet31.saidas'. Você pode movê-la ou removê-la conforme necessário.
            this.saidasTableAdapter.Fill(this.mydbDataSet31.saidas);
        }

        private void btnSaiEstRegSai_Click(object sender, EventArgs e)
        {

            if ((cbSaiEstProd.Text != "") && (txtSaiEstQtd.Text != "") && (txtSaiEstPrecVen.Text != ""))
            {
                this.saidasTableAdapter.Fill(this.mydbDataSet31.saidas);
                MySqlConnection conn = new MySqlConnection();
                MySqlCommand comando = new MySqlCommand();

                conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
                conn.Open();


                comando.Connection = conn;
                comando.CommandText = "insert into saidas(idProdutos,descricao,quantidade,preco,dataSaida) values (@idProdutos,@descricao,@quantidade,@preco,@dataSaida)";
                comando.Parameters.AddWithValue("@idProdutos", cbSaiEstProd.Text);
                comando.Parameters.AddWithValue("@descricao", txtSaiEstDet.Text);
                comando.Parameters.AddWithValue("@quantidade", txtSaiEstQtd.Text);
                comando.Parameters.AddWithValue("@preco", txtSaiEstPrecVen.Text);
                comando.Parameters.AddWithValue("@dataSaida", DateTime.Today);

                comando.ExecuteNonQuery();

                MessageBox.Show("Saída Cadastrada.");
                this.Close();
                Saidas inEst = new Saidas();
                inEst.Show();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnSaiEstExcSai_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();

            conn.ConnectionString = ("server=127.0.0.1;user id=root;password=GUB986_134/-/ul;persistsecurityinfo=True;database=mydb");
            conn.Open();

            comando.Connection = conn;
            comando.CommandText = ("DELETE FROM saidas WHERE idSaidas = @idSaidas");
            comando.Parameters.Add(new MySqlParameter("@idSaidas", Convert.ToInt32(dgvSaiEst.CurrentRow.Cells[0].Value)));

            comando.ExecuteNonQuery();

            MessageBox.Show("Entrada Excluída.");

            conn.Close();

            this.Close();
            Saidas inEst = new Saidas();
            inEst.Show();
        }

        private void txtSaiEstQtd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
