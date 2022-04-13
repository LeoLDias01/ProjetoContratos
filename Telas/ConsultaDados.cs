using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContratos
{
    public partial class ConsultaDados : Form
    {
        public ConsultaDados()
        {
            InitializeComponent();
        }

        private void BuscaBT_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid() 
        {

            string strcon = @"Data Source= DESKTOP-D99O6K1\SQLEXPRESS;Initial Catalog=Concilig;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon); /* conexao irá conectar o C# ao banco de dados */
            SqlCommand cmd = new SqlCommand("SELECT * FROM C_Contratos", conexao);
            try
            {
                conexao.Open(); // abre a conexão com o banco
                cmd.ExecuteNonQuery(); // executa cmd
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o
                    banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet
                dataGridView2.DataSource = ds; //Datagridview recebe ds já preenchido
                dataGridView2.DataMember = ds.Tables[0].TableName;
                /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void ChamaMenuBT_Click(object sender, EventArgs e)
        {
            Menu TelaMenu = new Menu();
            TelaMenu.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
