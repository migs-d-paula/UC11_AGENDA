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

            textBoxID.Enabled = false;
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            if (radioButtonBLOQUEADO.Checked)
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
            else
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "UPDATE tbl_agenda SET nome = '" + textBoxNOME.Text + "', sobrenome = '" + textBoxSOBRENOME.Text + "', telefone = '" + textBoxTELEFONE.Text + "', celular = '" + textBoxCELULAR.Text + "', email = '" + textBoxEMAIL.Text + "', linkedin = '" + textBoxLINKEDIN.Text + "', bloqueado = '" + radioButtonDESBLOQUEADO.Text + "' WHERE id = '" + textBoxID.Text + "';";
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
            textBoxTELEFONE.Text = dataGridViewSELECIONAR.CurrentRow.Cells[3].Value.ToString();
            textBoxCELULAR.Text = dataGridViewSELECIONAR.CurrentRow.Cells[4].Value.ToString();
            textBoxEMAIL.Text = dataGridViewSELECIONAR.CurrentRow.Cells[5].Value.ToString();
            textBoxLINKEDIN.Text = dataGridViewSELECIONAR.CurrentRow.Cells[6].Value.ToString();
        }

        private void labelVOLTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
