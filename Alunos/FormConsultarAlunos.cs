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

            List<string> cidades = db.BuscarCidadesCadastradas();

            foreach (string cidade in cidades)
            {
                cb_cidade.Items.Add(cidade);
            }

            status_matricula.Items.Add("ativa");
            status_matricula.Items.Add("inativa");
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
            cb_cidade.SelectedItem = null;
            txt_id.Text = "";
            txt_endereco.Text = "";
            data_nasc.Value = DateTime.Now;
            status_matricula.ClearSelected();
            dataGridView_alunos.DataSource= db.BuscarAlunos();
        }

        private void btn_pesquisar_aluno_Click(object sender, EventArgs e)
        {
            string matricula = txt_id.Text.Trim();
            string nome = txt_nome_aluno.Text.Trim();
            string email = txt_email.Text.Trim();
            string whatsapp = txt_whatsapp.Text.Trim();
            string cidade = cb_cidade.Text.Trim();
            string endereco = txt_endereco.Text.Trim();
            string dataNasc = data_nasc.Value.ToString("dd-MM-yyyy");

            string statusMatricula = status_matricula.CheckedItems.Count > 0 ? status_matricula.CheckedItems[0].ToString() : null;

            if (!string.IsNullOrEmpty(matricula))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorId(matricula);
            }
            else if (!string.IsNullOrEmpty(nome))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorNome(nome);
            }
            else if (!string.IsNullOrEmpty(email))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorEmail(email);
            }
            else if (!string.IsNullOrEmpty(whatsapp))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorWhatsapp(whatsapp);
            }
            else if (!string.IsNullOrEmpty(cidade))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorCidade(cidade);
            }
            else if (!string.IsNullOrEmpty(endereco))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorEndereco(endereco);
            }
            else if (!string.IsNullOrEmpty(statusMatricula))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorStatusMatricula(statusMatricula);
            }
            else if (!string.IsNullOrEmpty(dataNasc) && dataNasc != DateTime.Now.ToString("dd-MM-yyyy"))
            {
                dataGridView_alunos.DataSource = db.BuscarAlunoPorDataNasc(dataNasc);
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
