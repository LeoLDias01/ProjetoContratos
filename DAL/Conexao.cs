using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.DAL
{
    //classe que faz a conexão do banco
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();
        public Conexao()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-D99O6K1\SQLEXPRESS;Initial Catalog=Concilig;Integrated Security=True";
        }
        public SqlConnection conecta()
        {   
          
            if (conn.State == System.Data.ConnectionState.Closed) 
            {
                conn.Open();
            }
            return conn;
        }

        public void desconecta() 
        {
            conn.Close();
        }
    }
}
