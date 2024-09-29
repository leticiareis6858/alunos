namespace Alunos
{
    partial class FormExcluirAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluirAluno));
            this.dataGridView_alunos = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_aluno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_alunos
            // 
            this.dataGridView_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alunos.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView_alunos.Location = new System.Drawing.Point(39, 169);
            this.dataGridView_alunos.Name = "dataGridView_alunos";
            this.dataGridView_alunos.Size = new System.Drawing.Size(412, 250);
            this.dataGridView_alunos.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Thistle;
            this.txt_id.Location = new System.Drawing.Point(39, 55);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(111, 27);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula do Aluno:";
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(246, 52);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(88, 44);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(378, 24);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(73, 37);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(378, 70);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(73, 37);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(36, 434);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(43, 13);
            this.txt_nome.TabIndex = 8;
            this.txt_nome.Text = "Usuário";
            this.txt_nome.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(246, 102);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(88, 44);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Aluno:";
            // 
            // txt_nome_aluno
            // 
            this.txt_nome_aluno.BackColor = System.Drawing.Color.Thistle;
            this.txt_nome_aluno.Location = new System.Drawing.Point(39, 119);
            this.txt_nome_aluno.Multiline = true;
            this.txt_nome_aluno.Name = "txt_nome_aluno";
            this.txt_nome_aluno.Size = new System.Drawing.Size(162, 27);
            this.txt_nome_aluno.TabIndex = 11;
            // 
            // FormExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(484, 464);
            this.Controls.Add(this.txt_nome_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView_alunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExcluirAluno";
            this.Text = "Excluir Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_alunos;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_aluno;
    }
}