using ProjetoContratos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Modelo
{
    public class Control
    {
        public bool Exist;  //var para guardar o valor 
        public String Retorno = "";

        // Esse metodo acesso, serve para ver se o login existe no banco
        public bool acessando (String User, String Password)
        {   
            //Instancia classe LoginComandos
            LoginComandos logincomand = new LoginComandos();

            // Armazena em uma variável, pois se esta string ficar vazia não existe erro, mas se for preenchida, o erro será mostrado
            Exist = logincomand.VerificaLogin(User, Password);

            //if de comparação
           if(!logincomand.Retorno.Equals(""))
            {
                this.Retorno = logincomand.Retorno;
            }
            return Exist;
        } // fecha método "acesso"
        public String Cadastro(String usuario, String senha)
        {
            LoginComandos logincomand = new LoginComandos();
            this.Retorno = logincomand.Cadastrar(usuario, senha);

            return Retorno;
        }
    } //fecha Control
} //fecha Namespace
