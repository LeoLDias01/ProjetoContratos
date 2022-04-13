using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.DAL
{
    class LoginComandos
    {
        // bool começa como falso para não precisar fazer else dentro do "try" assim só precisa fazer 1 tratativa ao invés de duas
        public bool Exist = false;
        public string Retorno = "";
        SqlCommand comando_banco = new SqlCommand();

        //Instanciando classe de conexão
        Conexao conn = new Conexao();
        SqlDataReader dataRead;

        //A informação vem do controle que por sua vez encaminha os dados para as variaveis User e Password
        public bool VerificaLogin(String User, String Password)
        {
            //comandos sql pra ver se tem no banco os dados informados

            comando_banco.CommandText = "SELECT * FROM KeyUser WHERE CPF_USER = @User AND SENHA_USER = @Password";
            comando_banco.Parameters.AddWithValue("@User", User);
            comando_banco.Parameters.AddWithValue("@Password", Password);

            try
            {
                comando_banco.Connection = conn.conecta();
                dataRead = comando_banco.ExecuteReader(); //Pega a informação e olha se foi encontrado
                if (dataRead.HasRows) 
                { 
                  Exist = true;
                }
                conn.desconecta();
                dataRead.Close();
            }
            catch (SqlException)
            {
                this.Retorno = "Usuário e senha informados não conferem ou não estão cadastrados"; //Se der erro preenche a mensagem com erro
            }

            return Exist;
        }

        public String Cadastrar(String usuario, String senha)
        {
            //cadastra no banco o usuario
            comando_banco.CommandText = "INSERT INTO KeyUser VALUES (@cpf, @passe);";
            comando_banco.Parameters.AddWithValue("@cpf", usuario);
            comando_banco.Parameters.AddWithValue("@passe", senha);

            try
            {
                comando_banco.Connection = conn.conecta();
                comando_banco.ExecuteNonQuery();
                conn.desconecta();
                this.Retorno = "Cadastrado com Sucesso";
            }
            catch (SqlException)
            {
                this.Retorno = "Erro no banco"; 
            }
            return Retorno;
        }
    }
}
