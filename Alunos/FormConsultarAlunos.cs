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
    public partial class FormConsultarAlunos : Form
    {
        private Database db;
        public FormConsultarAlunos()
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
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_whatsapp.Text = "";
            txt_cidade.SelectedItem = null;
            txt_id.Text = "";
            txt_endereco.Text = "";
            data_nasc.Value = DateTime.Now;
            status_matricula.ClearSelected();
            dataGridView_alunos.DataSource= db.BuscarAlunos();
        }

        private void btn_pesquisar_aluno_Click(object sender, EventArgs e)
        {
            String matricula = txt_id.Text;
            String nome = txt_nome_aluno.Text;
            String email = txt_email.Text;
            String whatsapp = txt_whatsapp.Text;
            String cidade = txt_cidade.Text;
            String endereco = txt_endereco.Text;
            String dataNasc = data_nasc.Value.ToString("dd-MM-yyyy");
            String statusMatricula = status_matricula.Text;

            if (matricula != null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorId(matricula);
            }
            else if(nome!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorNome(nome);
            }
            else if(email!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorEmail(email);
            }
            else if(whatsapp!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorWhatsapp(whatsapp);
            }
            else if(cidade!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorCidade(cidade);
            }
            else if(endereco!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorEndereco(endereco);
            }
            else if(dataNasc!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorDataNasc(dataNasc);
            }
            else if(statusMatricula!=null)
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorStatusMatricula(statusMatricula);
            }
            else if(nome!=null&&matricula!=null&&email!=null && whatsapp != null && cidade != null && endereco != null && dataNasc != null && statusMatricula != null)
            {
                dataGridView_alunos.DataSource = db.BuscarAluno(nome, matricula, email, whatsapp, cidade, endereco, dataNasc, statusMatricula);
            }
            else
            {
                MessageBox.Show("Preencha ao menos um dos campos ou use o botão 'Pesquisar Alunos'!");
            }
        }

        private void btn_pesquisar_alunos_Click(object sender, EventArgs e)
        {
            dataGridView_alunos.DataSource = db.BuscarAlunos();
        }
    }
}
