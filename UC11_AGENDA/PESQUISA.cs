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
    public partial class PESQUISA : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public PESQUISA()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=agenda;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_agenda ORDER BY nome ASC;";

                MySqlDataAdapter adaptadorPESQUISA = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorPESQUISA.Fill(tabelaAGENDA);

                dataGridViewPESQUISA.DataSource = tabelaAGENDA;
                dataGridViewPESQUISA.Columns["id"].HeaderText = "ID";
                dataGridViewPESQUISA.Columns["nome"].HeaderText = "NOME";
                dataGridViewPESQUISA.Columns["sobrenome"].HeaderText = "SOBRENOME";
                dataGridViewPESQUISA.Columns["telefone"].HeaderText = "TELEFONE";
                dataGridViewPESQUISA.Columns["celular"].HeaderText = "CELULAR";
                dataGridViewPESQUISA.Columns["email"].HeaderText = "E-MAIL";
                dataGridViewPESQUISA.Columns["linkedin"].HeaderText = "LINKEDIN";
                dataGridViewPESQUISA.Columns["bloqueado"].HeaderText = "BLOQUEADO/DESBLOQUEADO";
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

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_agenda ORDER BY nome ASC;";

                MySqlDataAdapter adaptadorPESQUISA = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorPESQUISA.Fill(tabelaAGENDA);

                dataGridViewPESQUISA.DataSource = tabelaAGENDA;
                dataGridViewPESQUISA.Columns["id"].HeaderText = "ID";
                dataGridViewPESQUISA.Columns["nome"].HeaderText = "NOME";
                dataGridViewPESQUISA.Columns["sobrenome"].HeaderText = "SOBRENOME";
                dataGridViewPESQUISA.Columns["telefone"].HeaderText = "TELEFONE";
                dataGridViewPESQUISA.Columns["celular"].HeaderText = "CELULAR";
                dataGridViewPESQUISA.Columns["email"].HeaderText = "E-MAIL";
                dataGridViewPESQUISA.Columns["linkedin"].HeaderText = "LINKEDIN";
                dataGridViewPESQUISA.Columns["bloqueado"].HeaderText = "BLOQUEADO/DESBLOQUEADO";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonPESQUISAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_agenda WHERE nome LIKE '" + textBoxPESQUISA.Text + "' OR sobrenome LIKE '" + textBoxPESQUISA.Text + "' OR telefone LIKE '" + textBoxPESQUISA.Text + "' OR celular LIKE '" + textBoxPESQUISA.Text + "' OR linkedin LIKE '" + textBoxPESQUISA.Text + "' OR bloqueado LIKE '" + textBoxPESQUISA.Text + "' ;";

                MySqlDataAdapter adaptadorPESQUISA = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorPESQUISA.Fill(tabelaAGENDA);

                dataGridViewPESQUISA.DataSource = tabelaAGENDA;
                dataGridViewPESQUISA.Columns["id"].HeaderText = "ID";
                dataGridViewPESQUISA.Columns["nome"].HeaderText = "NOME";
                dataGridViewPESQUISA.Columns["sobrenome"].HeaderText = "SOBRENOME";
                dataGridViewPESQUISA.Columns["telefone"].HeaderText = "TELEFONE";
                dataGridViewPESQUISA.Columns["celular"].HeaderText = "CELULAR";
                dataGridViewPESQUISA.Columns["email"].HeaderText = "E-MAIL";
                dataGridViewPESQUISA.Columns["linkedin"].HeaderText = "LINKEDIN";
                dataGridViewPESQUISA.Columns["bloqueado"].HeaderText = "BLOQUEADO/DESBLOQUEADO";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao pesquisar na lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void labelVOLTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
