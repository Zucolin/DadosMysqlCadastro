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

namespace DadosMysqlCadastro
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=09876612vini;database=db_dados";
        public Form1()
        {
            InitializeComponent();

            listusuario.View = View.Details;
            listusuario.LabelEdit = true;
            listusuario.AllowColumnReorder = true;
            listusuario.FullRowSelect = true;
            listusuario.GridLines= true;
            listusuario.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listusuario.Columns.Add("Nome", 30, HorizontalAlignment.Left);
            listusuario.Columns.Add("E-mail", 30, HorizontalAlignment.Left);
            listusuario.Columns.Add("Senha", 30, HorizontalAlignment.Left);
        }

        private void botao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText = "INSERT INTO usuario (nome, email, senha) " +
                    "VALUES " +
                    "(@nome, @email, @senha) ";


                cmd.Parameters.AddWithValue("@nome", textnome.Text);
                cmd.Parameters.AddWithValue("@email", textemail.Text);
                cmd.Parameters.AddWithValue("@senha", textsenha.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Contato Inserido com Sucesso!",
                    "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + " ocorrido: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorrido: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Conexao.Close(); }
        }

        private void buscarbotao_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%"+ textbusca.Text +"%'"; 
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM usuario " +
                    "WHERE nome LIKE " + q + " OR email LIKE" + q;
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                listusuario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),

                    };
                    var linha_listview = new ListViewItem(row);
                    listusuario.Items.Add(linha_listview);


                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } finally { Conexao.Close();}
        }
    }
}
