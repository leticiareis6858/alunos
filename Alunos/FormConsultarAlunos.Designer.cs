namespace Alunos
{
    partial class FormConsultarAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_alunos = new System.Windows.Forms.DataGridView();
            this.txt_nome_aluno = new System.Windows.Forms.TextBox();
            this.txt_whatsapp = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.status_matricula = new System.Windows.Forms.CheckedListBox();
            this.txt_cidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data_nasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pesquisar_aluno = new System.Windows.Forms.Button();
            this.btn_pesquisar_alunos = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_alunos
            // 
            this.dataGridView_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alunos.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView_alunos.Location = new System.Drawing.Point(30, 285);
            this.dataGridView_alunos.Name = "dataGridView_alunos";
            this.dataGridView_alunos.Size = new System.Drawing.Size(831, 265);
            this.dataGridView_alunos.TabIndex = 1;
            // 
            // txt_nome_aluno
            // 
            this.txt_nome_aluno.BackColor = System.Drawing.Color.Thistle;
            this.txt_nome_aluno.Location = new System.Drawing.Point(30, 73);
            this.txt_nome_aluno.Name = "txt_nome_aluno";
            this.txt_nome_aluno.Size = new System.Drawing.Size(221, 20);
            this.txt_nome_aluno.TabIndex = 2;
            // 
            // txt_whatsapp
            // 
            this.txt_whatsapp.BackColor = System.Drawing.Color.Thistle;
            this.txt_whatsapp.Location = new System.Drawing.Point(278, 73);
            this.txt_whatsapp.Name = "txt_whatsapp";
            this.txt_whatsapp.Size = new System.Drawing.Size(213, 20);
            this.txt_whatsapp.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Thistle;
            this.txt_email.Location = new System.Drawing.Point(30, 184);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(221, 20);
            this.txt_email.TabIndex = 4;
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.Color.Thistle;
            this.txt_endereco.Location = new System.Drawing.Point(278, 130);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(223, 101);
            this.txt_endereco.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Thistle;
            this.txt_id.Location = new System.Drawing.Point(30, 128);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(221, 20);
            this.txt_id.TabIndex = 7;
            // 
            // status_matricula
            // 
            this.status_matricula.BackColor = System.Drawing.Color.Thistle;
            this.status_matricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_matricula.FormattingEnabled = true;
            this.status_matricula.Items.AddRange(new object[] {
            "ativa",
            "inativa"});
            this.status_matricula.Location = new System.Drawing.Point(521, 134);
            this.status_matricula.Name = "status_matricula";
            this.status_matricula.Size = new System.Drawing.Size(120, 46);
            this.status_matricula.TabIndex = 9;
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.Thistle;
            this.txt_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.FormattingEnabled = true;
            this.txt_cidade.Location = new System.Drawing.Point(30, 234);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(221, 28);
            this.txt_cidade.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Whatsapp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data de nascimento:";
            // 
            // data_nasc
            // 
            this.data_nasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nasc.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.data_nasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nasc.Location = new System.Drawing.Point(517, 66);
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.Size = new System.Drawing.Size(324, 26);
            this.data_nasc.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Status matricula:";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(559, 9);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(43, 13);
            this.txt_nome.TabIndex = 20;
            this.txt_nome.Text = "Usuário";
            this.txt_nome.Visible = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(786, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 30);
            this.btn_voltar.TabIndex = 21;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_pesquisar_aluno
            // 
            this.btn_pesquisar_aluno.BackColor = System.Drawing.Color.LightCoral;
            this.btn_pesquisar_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_aluno.Location = new System.Drawing.Point(521, 237);
            this.btn_pesquisar_aluno.Name = "btn_pesquisar_aluno";
            this.btn_pesquisar_aluno.Size = new System.Drawing.Size(320, 42);
            this.btn_pesquisar_aluno.TabIndex = 22;
            this.btn_pesquisar_aluno.Text = "Pesquisar aluno";
            this.btn_pesquisar_aluno.UseVisualStyleBackColor = false;
            this.btn_pesquisar_aluno.Click += new System.EventHandler(this.btn_pesquisar_aluno_Click);
            // 
            // btn_pesquisar_alunos
            // 
            this.btn_pesquisar_alunos.BackColor = System.Drawing.Color.LightCoral;
            this.btn_pesquisar_alunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar_alunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_alunos.Location = new System.Drawing.Point(521, 189);
            this.btn_pesquisar_alunos.Name = "btn_pesquisar_alunos";
            this.btn_pesquisar_alunos.Size = new System.Drawing.Size(320, 42);
            this.btn_pesquisar_alunos.TabIndex = 23;
            this.btn_pesquisar_alunos.Text = "Pesquisar alunos";
            this.btn_pesquisar_alunos.UseVisualStyleBackColor = false;
            this.btn_pesquisar_alunos.Click += new System.EventHandler(this.btn_pesquisar_alunos_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(278, 237);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(223, 32);
            this.btn_limpar.TabIndex = 24;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // FormConsultarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_pesquisar_alunos);
            this.Controls.Add(this.btn_pesquisar_aluno);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.data_nasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.status_matricula);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_whatsapp);
            this.Controls.Add(this.txt_nome_aluno);
            this.Controls.Add(this.dataGridView_alunos);
            this.Name = "FormConsultarAlunos";
            this.Text = "Consultar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_alunos;
        private System.Windows.Forms.TextBox txt_nome_aluno;
        private System.Windows.Forms.TextBox txt_whatsapp;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.CheckedListBox status_matricula;
        private System.Windows.Forms.ComboBox txt_cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker data_nasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisar_aluno;
        private System.Windows.Forms.Button btn_pesquisar_alunos;
        private System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.Label txt_nome;
    }
}