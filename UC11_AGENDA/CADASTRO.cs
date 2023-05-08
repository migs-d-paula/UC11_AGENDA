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
    public partial class CADASTRO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public CADASTRO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=agenda;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if (radioButtonBLOQUEADO.Checked)
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_agenda(nome, sobrenome, telefone, celular, email, linkedin, bloqueado) VALUES ('" + textBoxNOME.Text + "', '" + textBoxSOBRENOME.Text + "', '" + textBoxTELEFONE.Text + "','" + textBoxCELULAR.Text + "', '" + textBoxEMAIL.Text + "', '" + textBoxLINKEDIN.Text + "', '" + radioButtonBLOQUEADO.Text + "'); ";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("cadastrado");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
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
                    comando.CommandText = "INSERT INTO tbl_agenda(nome, sobrenome, telefone, celular, email, linkedin, bloqueado) VALUES ('" + textBoxNOME.Text + "', '" + textBoxSOBRENOME.Text + "', '" + textBoxTELEFONE.Text + "','" + textBoxCELULAR.Text + "', '" + textBoxEMAIL.Text + "', '" + textBoxLINKEDIN.Text + "', '" + radioButtonDESBLOQUEADO.Text + "'); ";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("cadastrado");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void labelVOLTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
