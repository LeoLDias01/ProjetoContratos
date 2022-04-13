using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContratos
{
    public partial class Importacao : Form
    {
        private string path;

        public Importacao()
        {
            InitializeComponent();
        }

        private void Importacao_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void ImportBT_Click(object sender, EventArgs e)
        {

            var filePath = string.Empty;
            // Tudo que está aqui seria melhor usar em uma classe ou método isolado, mas com o tempo reduzido foi colocado aqui na função do botão
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Busca diretório
                openFileDialog.InitialDirectory = "c:\\";
                //Tipo de arquivo suportado
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Pega o caminho do arquivo
                    filePath = openFileDialog.FileName;

                    //Lê o conteúdo
                    var fileStream = openFileDialog.OpenFile();
                }
            }
            //Message Box para mostrar conteúdo e avisar que deu certo
         MessageBox.Show(filePath, "Caminho: " + "Carregado com sucesso", MessageBoxButtons.OK);

            //Stream Reader que ao invés de ter um caminho pronto utiliza o caminho armazenado em file content
         StreamReader lendo_arquivo = new StreamReader(@filePath);
            string linha;
            string[] campo;
            while ((linha = lendo_arquivo.ReadLine()) != null)
            { 
              campo = linha.Split(';');
              dataGridView1.Rows.Add(campo);
            
            }
        } // fecha função botão
        public abstract class FileDialog : System.Windows.Forms.CommonDialog
        { 
            
        }

        private void ImportTXTbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportContinuaBT1_Click(object sender, EventArgs e)
        {
            //Abre novamente a conexão com o banco
            string conx = @"Data Source=DESKTOP-D99O6K1\SQLEXPRESS;Initial Catalog=Concilig;Integrated Security=True";
            SqlConnection conex = new SqlConnection(conx);
            // sql para inserir os dados
            string comandoSql = "INSERT INTO C_Contratos values (@nome_cliente, @cpf_cliente, @contrato, @produto, @vencimento, @valor)";
            try // try para conseguir mostrar erro no catch
            {
                conex.Open();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //contador iniciando da posião 0 que é a primeira casa, o for vai percorrer até acabar as linhas
                {
                    SqlCommand comando = new SqlCommand(comandoSql, conex);
                    comando.Parameters.AddWithValue("@nome_cliente", dataGridView1.Rows[i].Cells["nome"].Value); //Aqui é informado qual coluna do banco vai pegar qual coluna do data grid
                    comando.Parameters.AddWithValue("@cpf_cliente", dataGridView1.Rows[i].Cells["CPF"].Value);
                    comando.Parameters.AddWithValue("@contrato", dataGridView1.Rows[i].Cells["Contrato"].Value);
                    comando.Parameters.AddWithValue("@produto", dataGridView1.Rows[i].Cells["Produto"].Value);
                    comando.Parameters.AddWithValue("@vencimento", dataGridView1.Rows[i].Cells["Vencimento"].Value);
                    comando.Parameters.AddWithValue("@valor", dataGridView1.Rows[i].Cells["Valor"].Value);
                    comando.CommandText = comandoSql;
                    comando.ExecuteNonQuery();
                    

                }
                MessageBox.Show("Inserido com sucesso", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally 
            {
                conex.Close();
            }
            dataGridView1.Rows.Clear();
            conex.Close();

            Menu meuMenu = new Menu();
            meuMenu.Show();

        }
    }
}
