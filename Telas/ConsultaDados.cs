using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public string _strConn = @"Data Source=DESKTOP-D99O6K1\SQLEXPRESS;Initial Catalog=Concilig;Integrated Security=True";
        SqlCommand objcommand = null;
        SqlConnection conn = null;
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
            
            string strSql = "select * from C_Contratos";
            conn = new SqlConnection(_strConn);
            objcommand = new SqlCommand(strSql, conn);
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dataGridView2.DataSource = dtLista;
            }
            catch (Exception ex) 
            { 
              MessageBox.Show(ex.Message);
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
