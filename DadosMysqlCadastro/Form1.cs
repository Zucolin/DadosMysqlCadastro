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
        private int ?id_usuario_selecionado = null;
        public Form1()
        {
            InitializeComponent();


            listusuario.View = View.Details;
            listusuario.LabelEdit = true;
            listusuario.AllowColumnReorder = true;
            listusuario.FullRowSelect = true;
            listusuario.GridLines= true;
            listusuario.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listusuario.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listusuario.Columns.Add("E-mail", 200, HorizontalAlignment.Left);
            listusuario.Columns.Add("Senha", 100, HorizontalAlignment.Left);

            carregar_usuarios();
        }
        private void listusuario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listusuario.SelectedItems.Count == 0)
                return;
            ListView.SelectedListViewItemCollection itens_selecionados = listusuario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_usuario_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                textnome.Text = item.SubItems[1].Text;
                textemail.Text = item.SubItems[2].Text;
                textsenha.Text = item.SubItems[3].Text;

                botaoexcluir.Visible = true;

            }
        }
        private void botaonovo_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            id_usuario_selecionado = null;

            textnome.Text = String.Empty;
            textnome.Text = "";
            textemail.Text = "";
            textsenha.Text = "";

            textnome.Focus();
            botaoexcluir.Visible = false;
        }
        private void botao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if(id_usuario_selecionado == null)
                {
                    cmd.CommandText = "INSERT INTO usuario (nome, email, senha) " +
                        "VALUES " +
                        "(@nome, @email, @senha) ";


                    cmd.Parameters.AddWithValue("@nome", textnome.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text);
                    cmd.Parameters.AddWithValue("@senha", textsenha.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario Inserido com Sucesso!",
                        "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    cmd.CommandText = "UPDATE usuario SET nome=@nome, email=@email, senha=@senha WHERE id=@id ";


                    cmd.Parameters.AddWithValue("@nome", textnome.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text);
                    cmd.Parameters.AddWithValue("@senha", textsenha.Text);
                    cmd.Parameters.AddWithValue("@id", id_usuario_selecionado);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario Atualizado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


                textnome.Clear();
                textemail.Clear();
                textsenha.Clear();

                id_usuario_selecionado = null;

                carregar_usuarios();

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

        private void carregar_usuarios()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM usuario ORDER BY id DESC ";
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

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
                    listusuario.Items.Add(new ListViewItem(row));


                }
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
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;
                cmd.Parameters.AddWithValue("@q", "%" + textbusca.Text + "%");
                cmd.CommandText = "SELECT * FROM usuario WHERE nome LIKE @q OR email LIKE @q";
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

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
                    listusuario.Items.Add(new ListViewItem(row));


                }
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



        private void menuexcluir_Click_1(object sender, EventArgs e)
        {
            ExcluirUsuario();
        }

        public void ExcluirUsuario()
        {
            try
            {
                DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir?", "Confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM usuario WHERE id=@id ";



                    cmd.Parameters.AddWithValue("@id", id_usuario_selecionado);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    carregar_usuarios();
                    MessageBox.Show("Usuario Excluido com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Reset();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorrido: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorrido: " + ex.Message,
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void botaoexcluir_Click_1(object sender, EventArgs e)
        {
            ExcluirUsuario();
        }
    }
}
