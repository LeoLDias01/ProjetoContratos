using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContratos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginSubmitBT_Click(object sender, EventArgs e)
        {
            Importacao impt = new Importacao();
            impt.ShowDialog();
        }

        private void MenuSelectBT2_Click(object sender, EventArgs e)
        {
            ConsultaDados cnst = new ConsultaDados();
            cnst.ShowDialog();
        }

        private void ExistBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
