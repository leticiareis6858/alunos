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
    public partial class FormCadastrarAluno : Form
    {
        private Database db;
        public FormCadastrarAluno()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial=new FormTelaInicial();
            telaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_aluno.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            data_nascimento.Value = DateTime.Now;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String nome = txt_nome_aluno.Text.Trim();
            String email = txt_email.Text.Trim();
            String telefone = txt_telefone.Text.Trim();
            String data_nasc = data_nascimento.Value.ToString("dd-MM-yyyy").Trim();
            String cidade = txt_cidade.Text.Trim();
            String endereco = txt_endereco.Text.Trim();

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefone) && !string.IsNullOrEmpty(data_nasc) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(endereco))
            {
                db.cadastrarAluno(nome, email, telefone, data_nasc, cidade, endereco);
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
