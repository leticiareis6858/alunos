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
            txt_senha.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_data_nasc.Value = DateTime.Now;
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (txt_id.Text == null || txt_nome.Text == null || txt_email.Text == null || txt_telefone.Text == null || txt_senha.Text == null || txt_cidade.Text == null || txt_endereco.Text == null || txt_data_nasc.Value == DateTime.Now)
            {
                MessageBox.Show("Preencha ao menos um dos campos!");
            }

            else if (txt_id.Text!=null)
            {
                String id = txt_id.Text;


                if (txt_nome.Text != null)
                {
                    db.AtualizarNomeAluno(txt_nome.Text, id);
                    MessageBox.Show("Nome atualizado com sucesso!");
                }
                else if (txt_email.Text != null)
                {
                    db.AtualizarEmailAluno(txt_email.Text, id);
                    MessageBox.Show("Email atualizado com sucesso!");
                }
                else if (txt_telefone.Text != null)
                {
                    db.AtualizarTelefoneAluno(txt_telefone.Text, id);
                    MessageBox.Show("Telefone atualizado com sucesso!");
                }
                else if (txt_senha.Text != null)
                {
                    db.AtualizarSenhaAluno(txt_senha.Text, id);
                    MessageBox.Show("Senha atualizada com sucesso!");
                }
                else if (txt_cidade.Text != null)
                {
                    db.AtualizarCidadeAluno(txt_cidade.Text, id);
                    MessageBox.Show("Cidade atualizada com sucesso!");
                }
                else if (txt_endereco.Text != null)
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
                if (txt_email != null && txt_telefone != null && txt_senha != null && txt_cidade != null && txt_endereco != null && txt_data_nasc.Value != DateTime.Now)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_senha.Text, txt_cidade.Text, txt_endereco.Text, data_nasc, id);
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
            } 
            
            else if(txt_nome.Text!=null)
            {
                String id = db.BuscarIdAlunoPorNome(txt_nome.Text);

               if (txt_email.Text != null)
                {
                    db.AtualizarEmailAluno(txt_email.Text, id);
                    MessageBox.Show("Email atualizado com sucesso!");
                }
                else if (txt_telefone.Text != null)
                {
                    db.AtualizarTelefoneAluno(txt_telefone.Text, id);
                    MessageBox.Show("Telefone atualizado com sucesso!");
                }
                else if (txt_senha.Text != null)
                {
                    db.AtualizarSenhaAluno(txt_senha.Text, id);
                    MessageBox.Show("Senha atualizada com sucesso!");
                }
                else if (txt_cidade.Text != null)
                {
                    db.AtualizarCidadeAluno(txt_cidade.Text, id);
                    MessageBox.Show("Cidade atualizada com sucesso!");
                }
                else if (txt_endereco.Text != null)
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
                if (txt_email != null && txt_telefone != null && txt_senha != null && txt_cidade != null && txt_endereco != null && txt_data_nasc.Value != DateTime.Now)
                {
                    String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                    db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_senha.Text, txt_cidade.Text, txt_endereco.Text, data_nasc, id);
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
            if(txt_id.Text!=null)
            {
                String id = txt_id.Text;

                txt_nome.Text=db.BuscarNomeAlunoPorMatricula(id);
                txt_email.Text = db.BuscarEmailAlunoPorMatricula(id);
                txt_senha.Text=db.BuscarSenhaAlunoPorMatricula(id);
                txt_telefone.Text = db.BuscarWhatsappAlunoPorMatricula(id);
                txt_endereco.Text = db.BuscarEnderecoAlunoPorMatricula(id);
                txt_data_nasc.Value = db.BuscarDataNascAlunoPorMatricula(id);
                txt_cidade.Text = db.BuscarCidadeAlunoPorMatricula(id);
            }
            else if(txt_nome.Text!=null)
            {
                String nome = txt_nome.Text;
                txt_nome.Text=db.BuscarNomeAluno(nome);
                txt_email.Text = db.BuscarEmailAlunoPorNome(nome);
                txt_senha.Text= db.BuscarSenhaAlunoPorNome(nome);
                txt_telefone.Text=db.BuscarWhatsappAlunoPorNome(nome);
                txt_endereco.Text = db.BuscarEnderecoAlunoPorNome(nome);
                txt_data_nasc.Value = db.BuscarDataNascAlunoPorNome(nome);
                txt_cidade.Text = db.BuscarCidadeAlunoPorNome(nome);
            }
            else
            {
                MessageBox.Show("Erro ao buscar aluno. Informe o id ou nome do aluno!");
            }
        }
    }
}
