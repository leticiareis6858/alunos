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
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            FormLogin telaLogin=new FormLogin();
            this.Hide();
            telaLogin.ShowDialog();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarAluno formCadastrarAluno= new FormCadastrarAluno();
            formCadastrarAluno.txt_nome.Text=txt_nome.Text;
            this.Hide();
            formCadastrarAluno.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarAluno telaAtualizarAluno = new FormAtualizarAluno();
            telaAtualizarAluno.txt_nome_usuario.Text = txt_nome.Text;
            this.Hide();
            telaAtualizarAluno.ShowDialog();
            this.Close();   
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            FormConsultarAlunos formConsultarAlunos= new FormConsultarAlunos();
            formConsultarAlunos.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formConsultarAlunos.ShowDialog();
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            FormExcluirAluno telaExcluirAluno = new FormExcluirAluno();
            telaExcluirAluno.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaExcluirAluno.ShowDialog();
            this.Close();
        }
    }
}
