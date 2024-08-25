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
    public partial class FormLogin : Form
    {
        private Database db;
        public FormLogin()
        {
            InitializeComponent();
            db = new Database();
            db.CreateTables();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == null)
            {
                MessageBox.Show("Informe um email");
            }
            else if (txt_senha.Text == null)
            {
                MessageBox.Show("Informe uma senha");
            }

            string email = txt_email.Text.Trim();
            string senha = txt_senha.Text.Trim();

            bool usuarioValido = db.VerificarLogin(email, senha);

            if (usuarioValido)
            {
                String nome = db.BuscarNomeUsuarioPorEmail(email);

                FormTelaInicial telaInicial = new FormTelaInicial();
                telaInicial.txt_nome.Text = nome;
                this.Hide();
                telaInicial.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Email ou senha inválidos!");
            }
        }

        private void link_mudar_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarSenha recuperarSenha = new FormRecuperarSenha();
            recuperarSenha.txt_email.Text=txt_email.Text;
            this.Hide();
            recuperarSenha.ShowDialog();
            this.Close();
        }

        private void link_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTelaCadastroUsuario cadastroUsuario = new FormTelaCadastroUsuario();
            this.Hide();
            cadastroUsuario.ShowDialog();
            this.Close();
        }
    }
}
