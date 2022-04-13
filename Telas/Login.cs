using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoContratos.DAL;
using ProjetoContratos.Modelo;

namespace ProjetoContratos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginLableConcilig_Click(object sender, EventArgs e)
        {

        }

        private void LoginSubmitBT_Click(object sender, EventArgs e)
        {
            Modelo.Control controlador = new Modelo.Control();
            controlador.acessando(LoginTxtBox1.Text, LoginTxtBox2.Text);

            if (controlador.Exist)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu Mn = new Menu();
                Mn.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERRO Login não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginCadBT_Click(object sender, EventArgs e)
        {
            CadastroUsuario CadUs = new CadastroUsuario();
            CadUs.ShowDialog();
        }
    }
}
