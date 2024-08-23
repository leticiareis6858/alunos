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
            telaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_aluno.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_senha.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_data_nasc.Value = DateTime.Now;
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            String id = txt_id.Text;
            if (txt_nome.Text==null || txt_email.Text == null || txt_telefone.Text == null || txt_senha.Text == null || txt_cidade.Text == null || txt_endereco.Text == null || txt_data_nasc.Value == DateTime.Now)
            {
                MessageBox.Show("Preencha ao menos um dos campos!");
            }
            else if(txt_aluno.Text != null)
            {
                db.AtualizarNomeAluno(txt_aluno.Text, id);
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
                db.AtualizarDataNascAluno( data_nasc, id);
                MessageBox.Show("Data de nascimento atualizada com sucesso!");
            }
            if (txt_email != null && txt_telefone != null && txt_senha != null && txt_cidade != null && txt_endereco != null && txt_data_nasc.Value != DateTime.Now)
            {
                String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_senha.Text, txt_cidade.Text, txt_endereco.Text, data_nasc,id);
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }
        }

    }
}
