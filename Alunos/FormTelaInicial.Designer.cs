namespace Alunos
{
    partial class FormTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaInicial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 261);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O que deseja fazer?";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(30, 34);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(159, 84);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar um aluno";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(233, 146);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(159, 84);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "Excluir aluno";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(30, 146);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(159, 84);
            this.btn_pesquisar.TabIndex = 5;
            this.btn_pesquisar.Text = "Pesquisar alunos";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(233, 34);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(159, 84);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.Text = "Atualizar aluno";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightCoral;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(406, 24);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 18;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(196, 46);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(62, 24);
            this.txt_nome.TabIndex = 17;
            this.txt_nome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seja bem vindo(a),";
            // 
            // FormTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(502, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaInicial";
            this.Text = "Tela Inicial";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        public System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label label1;
    }
}