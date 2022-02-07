using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ToDo_HJ
{
    public partial class ToDo : Form
    {
        
        SqlConnection ConexaoSQL = new SqlConnection(@"Data Source=(localdb)\ToDo;Initial Catalog=Base_de_Dados;Integrated Security=True;");
        SqlCommand ComandoSQL;
        SqlDataAdapter DA;
        SqlDataReader DR;
        string StringSQL = string.Empty;

        string Modo = "";

        public ToDo()
        {
            InitializeComponent();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            SetarDadosDGV();

            

        }

        private void eliminarTarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                StringSQL = "delete Tarefas where tarefa = @tarefa";
                ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);


                ComandoSQL.Parameters.AddWithValue("@tarefa", dgv_tarefas.SelectedCells[0].Value.ToString());

                ConexaoSQL.Open();
                ComandoSQL.ExecuteNonQuery();
                MessageBox.Show("Tarefa Excluida com Sucesso...");
                Form j;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                ConexaoSQL.Close();
                StringSQL = string.Empty;
                SetarDadosDGV();
                TabPaginas.SelectedTab = Lista;
            }
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_AddTarefa.Text = "Adicionar";
            concluirtoolStripMenuItem1.Text = "Adicionar";
            Modo = "Adição";
            TabPaginas.SelectedTab = View_Tarefa;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TabPaginas.SelectedTab = Lista;
            Clean();
        }

        private void btn_AddTarefa_Click(object sender, EventArgs e)
        {
            if (Modo == "Edição")
            {
                try
                {
                    StringSQL = "update Tarefas set tarefa = @tarefa, concluida = @concluida, descricao = @descricao where tarefa = @tarefa";
                    ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);



                    ComandoSQL.Parameters.AddWithValue("@tarefa", txt_tarefa.Text);
                    ComandoSQL.Parameters.AddWithValue("@concluida", chkb_conluido.Checked ? "Concluida" : "N/Concluida");
                    ComandoSQL.Parameters.AddWithValue("@descricao", txt_descricaoTarefa.Text);

                    ConexaoSQL.Open();
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Alterada com Sucesso...");


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    ConexaoSQL.Close();
                    StringSQL = string.Empty;
                    SetarDadosDGV();
                    Clean();
                    TabPaginas.SelectedTab = Lista;
                }
            }
            else if (Modo == "Adição")
            {
                try
                {
                    StringSQL = "insert into Tarefas (tarefa, data, concluida, descricao) values (@tarefa, @data, @concluida, @descricao)";
                    ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);

                    string concluida = chkb_conluido.Checked ? "Concluida" : "N/Concluida";
                    string data = (DateTime.Today.Date.Day).ToString() + "/" + DateTime.Today.Date.Month + "/" + DateTime.Today.Date.Year;

                    ComandoSQL.Parameters.AddWithValue("@tarefa", txt_tarefa.Text);
                    ComandoSQL.Parameters.AddWithValue("@data", data);
                    ComandoSQL.Parameters.AddWithValue("@concluida", concluida);
                    ComandoSQL.Parameters.AddWithValue("@descricao", txt_descricaoTarefa.Text);

                    ConexaoSQL.Open();
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Adicionada com Sucesso...");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    ConexaoSQL.Close();
                    StringSQL = string.Empty;
                    SetarDadosDGV();
                    Clean();
                    TabPaginas.SelectedTab = Lista;
                }
            }
        }

        private void Clean()
        {
            txt_descricaoTarefa.Text = string.Empty;
            txt_tarefa.Text = string.Empty;
            chkb_conluido.Checked = false;
        }

        private void SetarDadosDGV()
        {
            try
            {
                StringSQL = "select * from Tarefas";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, ConexaoSQL);
                ConexaoSQL.Open();
                DA.Fill(DS);

                dgv_tarefas.DataSource = DS.Tables[0];

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                ConexaoSQL.Close();
                StringSQL = string.Empty;
            }
        }

        private void verTarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modo = "Edição";
            btn_AddTarefa.Text = "Salvar Alterações";
            concluirtoolStripMenuItem1.Text = "Salvar Alterações";
            try
            {
                StringSQL = "select * from Tarefas where tarefa = @tarefa";
                ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);

                ComandoSQL.Parameters.AddWithValue("@tarefa", dgv_tarefas.SelectedCells[0].Value.ToString());
                ConexaoSQL.Open();
                DR = ComandoSQL.ExecuteReader();
                string chkbox;
                while (DR.Read())
                {
                    txt_tarefa.Text = (string)DR["tarefa"];
                    txt_descricaoTarefa.Text = (string)DR["descricao"];
                    chkbox = (string)DR["concluida"];
                    chkbox = chkbox.Trim();
                    if (chkbox == "Concluida")
                    {
                        chkb_conluido.Checked = true;
                    }
                    else
                    {
                        chkb_conluido.Checked = false;
                    }
                }
            }
            catch (Exception erro)
            {
                throw;
            }
            finally
            {
                ConexaoSQL.Close();
                StringSQL = string.Empty;
                SetarDadosDGV();
                TabPaginas.SelectedTab = View_Tarefa;
                txt_descricaoTarefa.Text = txt_descricaoTarefa.Text.Trim();
                txt_tarefa.Text = txt_tarefa.Text.Trim();
            }
        }

        private void txt_tarefa_TextChanged(object sender, EventArgs e)
        {
            lbl_caracteres.Text = txt_tarefa.Text.Length + "/20";
        }

        private void txt_descricaoTarefa_TextChanged(object sender, EventArgs e)
        {
            lbl_caracteres2.Text = txt_descricaoTarefa.Text.Length + "/300";
        }

        private void concluirtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modo == "Edição")
            {
                try
                {
                    StringSQL = "update Tarefas set tarefa = @tarefa, concluida = @concluida, descricao = @descricao where tarefa = @tarefa";
                    ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);



                    ComandoSQL.Parameters.AddWithValue("@tarefa", txt_tarefa.Text);
                    ComandoSQL.Parameters.AddWithValue("@concluida", chkb_conluido.Checked ? "Concluida" : "N/Concluida");
                    ComandoSQL.Parameters.AddWithValue("@descricao", txt_descricaoTarefa.Text);

                    ConexaoSQL.Open();
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Alterada com Sucesso...");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    ConexaoSQL.Close();
                    StringSQL = string.Empty;
                    SetarDadosDGV();
                    Clean();
                    TabPaginas.SelectedTab = Lista;
                }
            }
            else if (Modo == "Adição")
            {
                try
                {
                    StringSQL = "insert into Tarefas (tarefa, data, concluida, descricao) values (@tarefa, @data, @concluida, @descricao)";
                    ComandoSQL = new SqlCommand(StringSQL, ConexaoSQL);

                    string concluida = chkb_conluido.Checked ? "Concluida" : "N/Concluida";
                    string data = (DateTime.Today.Date.Day).ToString() + "/" + DateTime.Today.Date.Month + "/" + DateTime.Today.Date.Year;

                    ComandoSQL.Parameters.AddWithValue("@tarefa", txt_tarefa.Text);
                    ComandoSQL.Parameters.AddWithValue("@data", data);
                    ComandoSQL.Parameters.AddWithValue("@concluida", concluida);
                    ComandoSQL.Parameters.AddWithValue("@descricao", txt_descricaoTarefa.Text);

                    ConexaoSQL.Open();
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Adicionada com Sucesso...");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    ConexaoSQL.Close();
                    StringSQL = string.Empty;
                    SetarDadosDGV();
                    Clean();
                    TabPaginas.SelectedTab = Lista;
                }
            }
        }
    }
}
