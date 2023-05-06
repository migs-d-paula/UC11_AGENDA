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
    public partial class ALTERAR : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public ALTERAR()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=agenda;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_agenda SET nome = '" + textBoxNOME.Text + "', sobrenome = '" + textBoxSOBRENOME.Text + "', telefone = '" + textBoxTELEFONE.Text + "', celular = '" + textBoxCELULAR.Text + "', email = '" + textBoxEMAIL.Text + "', linkedin = '" + textBoxLINKEDIN.Text + "', bloqueado = '" + radioButtonBLOQUEADO.Text + "' WHERE id = '" + textBoxID.Text + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("alterado com sucesso");
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao alterar, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
