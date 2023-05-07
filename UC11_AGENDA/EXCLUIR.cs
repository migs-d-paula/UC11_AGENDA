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

            textBoxID.Enabled = false;
            textBoxNOME.Enabled = false;
            textBoxSOBRENOME.Enabled = false;
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

        private void labelSELECIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_agenda ORDER BY nome ASC;";

                MySqlDataAdapter adaptadorSELECIONAR = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorSELECIONAR.Fill(tabelaAGENDA);

                dataGridViewSELECIONAR.DataSource = tabelaAGENDA;
                dataGridViewSELECIONAR.Columns["id"].HeaderText = "ID";
                dataGridViewSELECIONAR.Columns["nome"].HeaderText = "NOME";
                dataGridViewSELECIONAR.Columns["sobrenome"].HeaderText = "SOBRENOME";
                dataGridViewSELECIONAR.Columns["telefone"].HeaderText = "TELEFONE";
                dataGridViewSELECIONAR.Columns["celular"].HeaderText = "CELULAR";
                dataGridViewSELECIONAR.Columns["email"].HeaderText = "E-MAIL";
                dataGridViewSELECIONAR.Columns["linkedin"].HeaderText = "LINKEDIN";
                dataGridViewSELECIONAR.Columns["bloqueado"].HeaderText = "BLOQUEADO/DESBLOQUEADO";
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridViewSELECIONAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewSELECIONAR.CurrentRow.Cells[0].Value.ToString();
            textBoxNOME.Text = dataGridViewSELECIONAR.CurrentRow.Cells[1].Value.ToString();
            textBoxSOBRENOME.Text = dataGridViewSELECIONAR.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
