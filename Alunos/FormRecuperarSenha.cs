using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos
{
    public partial class FormRecuperarSenha : Form
    {
        private Database db;
        public FormRecuperarSenha()
        {
            InitializeComponent();
            db=new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin= new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btn_mudar_Click(object sender, EventArgs e)
        {
            String nome = txt_nome.Text.Trim();
            String email = txt_email.Text.Trim();
            String novaSenha = txt_nova_senha.Text.Trim();

            bool usuarioValido = db.VerificarNomeEmailUsuario(email, nome);

            if (usuarioValido)
            {
                bool mudarSenha = db.MudarSenha(email, novaSenha);
                MessageBox.Show("Senha alterada com sucesso!");

            }
            else if(!usuarioValido)
            {
                MessageBox.Show("Nome de usuário e/ou email inválidos!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar senha");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_nova_senha.Clear();
        }
    }
}
