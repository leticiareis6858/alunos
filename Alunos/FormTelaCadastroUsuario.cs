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
    public partial class FormTelaCadastroUsuario : Form
    {
        private Database db;
        public FormTelaCadastroUsuario()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String nome = txt_nome.Text.Trim();
            String email = txt_email.Text.Trim();
            String senha = txt_senha.Text.Trim();

            if (!nome.Equals("") && !email.Equals("") && !senha.Equals(""))
            {
                bool usuarioCadastrado=db.CadastrarUsuario(nome, email, senha);
                if (usuarioCadastrado)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                } 
                else if(!usuarioCadastrado)
                {
                    MessageBox.Show("Erro ao cadastrar usuário! Talvez o email informado já esteja sendo usado.");
                }
                
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial = new FormTelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }
    }
}
