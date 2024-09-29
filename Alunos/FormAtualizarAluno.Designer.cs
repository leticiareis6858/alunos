namespace Alunos
{
    partial class FormAtualizarAluno
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
            this.txt_data_nasc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_alunos = new System.Windows.Forms.DataGridView();
            this.txt_nome_usuario = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status_matricula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_data_nasc
            // 
            this.txt_data_nasc.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.txt_data_nasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_data_nasc.Location = new System.Drawing.Point(65, 298);
            this.txt_data_nasc.Name = "txt_data_nasc";
            this.txt_data_nasc.Size = new System.Drawing.Size(220, 20);
            this.txt_data_nasc.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Data de nascimento:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.Thistle;
            this.txt_cidade.Location = new System.Drawing.Point(304, 127);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(228, 20);
            this.txt_cidade.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Cidade:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.Color.Thistle;
            this.txt_endereco.Location = new System.Drawing.Point(65, 239);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(223, 20);
            this.txt_endereco.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Thistle;
            this.txt_nome.Location = new System.Drawing.Point(65, 127);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(223, 20);
            this.txt_nome.TabIndex = 87;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(434, 216);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(102, 49);
            this.btn_limpar.TabIndex = 84;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(473, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(78, 30);
            this.btn_voltar.TabIndex = 83;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.Thistle;
            this.txt_telefone.Location = new System.Drawing.Point(65, 185);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(223, 20);
            this.txt_telefone.TabIndex = 81;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Thistle;
            this.txt_email.Location = new System.Drawing.Point(304, 78);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(227, 20);
            this.txt_email.TabIndex = 80;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(308, 216);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(102, 49);
            this.btn_atualizar.TabIndex = 79;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "E-mail:";
            // 
            // dataGridView_alunos
            // 
            this.dataGridView_alunos.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alunos.Location = new System.Drawing.Point(49, 337);
            this.dataGridView_alunos.Name = "dataGridView_alunos";
            this.dataGridView_alunos.Size = new System.Drawing.Size(483, 196);
            this.dataGridView_alunos.TabIndex = 94;
            // 
            // txt_nome_usuario
            // 
            this.txt_nome_usuario.AutoSize = true;
            this.txt_nome_usuario.Location = new System.Drawing.Point(12, 536);
            this.txt_nome_usuario.Name = "txt_nome_usuario";
            this.txt_nome_usuario.Size = new System.Drawing.Size(43, 13);
            this.txt_nome_usuario.TabIndex = 95;
            this.txt_nome_usuario.Text = "Usuário";
            this.txt_nome_usuario.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(64, 55);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(142, 20);
            this.labelid.TabIndex = 96;
            this.labelid.Text = "Matrícula do aluno:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Thistle;
            this.txt_id.Location = new System.Drawing.Point(65, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 20);
            this.txt_id.TabIndex = 97;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(309, 275);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(227, 43);
            this.btn_buscar.TabIndex = 98;
            this.btn_buscar.Text = "Pesquisar aluno";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(304, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Status da matrícula:";
            // 
            // cb_status_matricula
            // 
            this.cb_status_matricula.BackColor = System.Drawing.Color.Thistle;
            this.cb_status_matricula.FormattingEnabled = true;
            this.cb_status_matricula.Items.AddRange(new object[] {
            "Ativa",
            "Inativa"});
            this.cb_status_matricula.Location = new System.Drawing.Point(303, 185);
            this.cb_status_matricula.Name = "cb_status_matricula";
            this.cb_status_matricula.Size = new System.Drawing.Size(228, 21);
            this.cb_status_matricula.TabIndex = 100;
            // 
            // FormAtualizarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(591, 558);
            this.Controls.Add(this.cb_status_matricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.txt_nome_usuario);
            this.Controls.Add(this.dataGridView_alunos);
            this.Controls.Add(this.txt_data_nasc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormAtualizarAluno";
            this.Text = "Atualizar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_data_nasc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_alunos;
        public System.Windows.Forms.Label txt_nome_usuario;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status_matricula;
    }
}