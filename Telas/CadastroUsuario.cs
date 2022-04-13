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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void CadSubmitBT_Click(object sender, EventArgs e)
        {  
            Modelo.Control controle = new Modelo.Control();
            controle.Cadastro(CadTxtBox1.Text, CadTxtBox2.Text);
            Login lg = new Login();
            MessageBox.Show("SUCESSO", "Login cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lg.ShowDialog();
        }
    }
}
