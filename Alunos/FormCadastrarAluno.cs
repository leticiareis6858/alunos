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
            data_nascimento.Value = DateTime.Now;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String nome = txt_nome.Text.Trim();
            String email = txt_email.Text.Trim();
            String senha = txt_senha.Text.Trim();
            String telefone = txt_telefone.Text.Trim();
            String data_nasc = data_nascimento.Value.ToString("dd-MM-yyyy").Trim();
            String cidade = txt_cidade.Text.Trim();
            String endereco = txt_endereco.Text.Trim();

            if (!nome.Equals("") && !email.Equals("") && !senha.Equals("") && !telefone.Equals("") && !data_nasc.Equals("") && !cidade.Equals("") && !endereco.Equals(""))
            {
                db.cadastrarAluno(nome, email, senha, telefone, data_nasc, cidade, endereco);
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
