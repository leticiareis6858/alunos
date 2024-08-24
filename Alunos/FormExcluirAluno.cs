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
    public partial class FormExcluirAluno : Form
    {
        private Database db;
        public FormExcluirAluno()
        {
            InitializeComponent();
            db = new Database();
            DataTable alunos = db.BuscarAlunos();

            dataGridView_alunos.DataSource = alunos;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            String idAluno = txt_id.Text;

            if(idAluno!=null)
            {
                bool alunoExcluido = db.ExcluirAluno(idAluno);
                
                if(alunoExcluido)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    DataTable alunos = db.BuscarAlunos();
                    dataGridView_alunos.DataSource = alunos;
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            } else
            {
                MessageBox.Show("Informe o ID do aluno a ser excluído");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial = new FormTelaInicial();
            telaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String id = txt_id.Text;
            if (id != null)
            {
                DataTable aluno = db.BuscarAluno(id);
                dataGridView_alunos.DataSource = aluno;
            }
            else if(txt_nome_aluno.Text!=null)
            {
               id = txt_nome_aluno.Text;
               DataTable aluno = db.BuscarAluno(id);
               dataGridView_alunos.DataSource = aluno;

            }
            else
            {
                MessageBox.Show("Informe o ID do aluno a ser buscado");
            }
        }
    }
}
