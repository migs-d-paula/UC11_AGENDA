using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace UC11_AGENDA
{
    public partial class EXCLUIR : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public EXCLUIR()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=agenda;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void EXCLUIR_Load(object sender, EventArgs e)
        {

        }

        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE from tbl_agenda where id = '" + textBoxID.Text + "' AND nome = '" + textBoxNOME.Text + "' AND sobrenome = '" + textBoxSOBRENOME.Text + "' ;";
                comando.ExecuteNonQuery();
                MessageBox.Show("excluido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao excluir, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
