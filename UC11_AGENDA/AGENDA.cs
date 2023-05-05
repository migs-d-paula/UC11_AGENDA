using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_AGENDA
{
    public partial class AGENDA : Form
    {
        public AGENDA()
        {
            InitializeComponent();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            Form CADASTRO = new CADASTRO();
            CADASTRO.Show();
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            Form ALTERAR = new ALTERAR();
            ALTERAR.Show();
        }

        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
            Form EXCLUIR = new EXCLUIR();
            EXCLUIR.Show();
        }

        private void buttonPESQUISA_Click(object sender, EventArgs e)
        {
            Form PESQUISA = new PESQUISA();
            PESQUISA.Show();
        }
    }
}
