using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos
{
    public partial class FormAtualizarAluno : Form
    {
        private Database db;
        public FormAtualizarAluno()
        {
            InitializeComponent();
            db = new Database();
            DataTable alunos = db.BuscarAlunos();

            dataGridView_alunos.DataSource = alunos;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial = new FormTelaInicial();
            telaInicial.txt_nome.Text = txt_nome_usuario.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_data_nasc.Value = DateTime.Now;
            cb_status_matricula.SelectedItem = null;
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_telefone.Text) || string.IsNullOrEmpty(txt_cidade.Text) || string.IsNullOrEmpty(txt_endereco.Text) || txt_data_nasc.Value == DateTime.Now || cb_status_matricula.SelectedItem == null)
            {
                MessageBox.Show("Preencha ao menos um dos campos!");
            }
            else if (!string.IsNullOrEmpty(txt_id.Text))
            {
                String id = txt_id.Text;

                if (!string.IsNullOrEmpty(txt_nome.Text))
                {
                    db.AtualizarNomeAluno(txt_nome.Text, id);
                    MessageBox.Show("Nome atualizado com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_email.Text))
                {
                    db.AtualizarEmailAluno(txt_email.Text, id);
                    MessageBox.Show("Email atualizado com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_telefone.Text))
                {
                    db.AtualizarTelefoneAluno(txt_telefone.Text, id);
                    MessageBox.Show("Telefone atualizado com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    db.AtualizarCidadeAluno(txt_cidade.Text, id);
                    MessageBox.Show("Cidade atualizada com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_endereco.Text))
                {
                    db.AtualizarEnderecoAluno(txt_endereco.Text, id);
                    MessageBox.Show("Endereço atualizado com sucesso!");
                }
                else if (txt_data_nasc.Value != DateTime.Now)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    db.AtualizarDataNascAluno(data_nasc, id);
                    MessageBox.Show("Data de nascimento atualizada com sucesso!");
                }
                else if(cb_status_matricula.SelectedItem != null)
                {
                    String status_matricula = cb_status_matricula.SelectedItem.ToString();
                    db.AtualizarStatusMatriculaAluno(status_matricula, id);
                    MessageBox.Show("Status da matrícula atualizado com sucesso!");

                }
                if (!string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_telefone.Text) && !string.IsNullOrEmpty(txt_cidade.Text) && !string.IsNullOrEmpty(txt_endereco.Text) && txt_data_nasc.Value != DateTime.Now && cb_status_matricula.SelectedItem != null)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    String status_matricula = cb_status_matricula.SelectedItem.ToString();
                    db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_cidade.Text, txt_endereco.Text, data_nasc, status_matricula, id);
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
            }
            else if (!string.IsNullOrEmpty(txt_nome.Text))
            {
                String id = db.BuscarIdAlunoPorNome(txt_nome.Text);

                if (!string.IsNullOrEmpty(txt_email.Text))
                {
                    db.AtualizarEmailAluno(txt_email.Text, id);
                    MessageBox.Show("Email atualizado com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_telefone.Text))
                {
                    db.AtualizarTelefoneAluno(txt_telefone.Text, id);
                    MessageBox.Show("Telefone atualizado com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    db.AtualizarCidadeAluno(txt_cidade.Text, id);
                    MessageBox.Show("Cidade atualizada com sucesso!");
                }
                else if (!string.IsNullOrEmpty(txt_endereco.Text))
                {
                    db.AtualizarEnderecoAluno(txt_endereco.Text, id);
                    MessageBox.Show("Endereço atualizado com sucesso!");
                }
                else if (txt_data_nasc.Value != DateTime.Now)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    db.AtualizarDataNascAluno(data_nasc, id);
                    MessageBox.Show("Data de nascimento atualizada com sucesso!");
                }
                else if (cb_status_matricula.SelectedItem != null)
                {
                    String status_matricula = cb_status_matricula.SelectedItem.ToString();
                    db.AtualizarStatusMatriculaAluno(status_matricula, id);
                    MessageBox.Show("Status da matrícula atualizado com sucesso!");

                }
                if (!string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_telefone.Text) && !string.IsNullOrEmpty(txt_cidade.Text) && !string.IsNullOrEmpty(txt_endereco.Text) && txt_data_nasc.Value != DateTime.Now && cb_status_matricula.SelectedItem != null)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    String status_matricula = cb_status_matricula.SelectedItem.ToString();
                    db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_cidade.Text, txt_endereco.Text, data_nasc,status_matricula, id);
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Erro ao atualizar aluno!");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string nome = txt_nome.Text.Trim();

            if (!string.IsNullOrEmpty(id))
            {
                txt_nome.Text = db.BuscarNomeAlunoPorMatricula(id);
                txt_email.Text = db.BuscarEmailAlunoPorMatricula(id);
                txt_telefone.Text = db.BuscarWhatsappAlunoPorMatricula(id);
                txt_endereco.Text = db.BuscarEnderecoAlunoPorMatricula(id);
                txt_data_nasc.Value = DateTime.Parse(db.BuscarDataNascAlunoPorMatricula(id));
                txt_cidade.Text = db.BuscarCidadeAlunoPorMatricula(id);
            }
            else if (!string.IsNullOrEmpty(nome))
            {
                txt_nome.Text = db.BuscarNomeAluno(nome);
                txt_email.Text = db.BuscarEmailAlunoPorNome(nome);
                txt_telefone.Text = db.BuscarWhatsappAlunoPorNome(nome);
                txt_endereco.Text = db.BuscarEnderecoAlunoPorNome(nome);
                txt_data_nasc.Value = DateTime.Parse(db.BuscarDataNascAlunoPorNome(nome));
                txt_cidade.Text = db.BuscarCidadeAlunoPorNome(nome);
            }
            else
            {
                MessageBox.Show("Erro ao buscar aluno. Informe o id ou nome do aluno!");
            }
        }
    }
}
