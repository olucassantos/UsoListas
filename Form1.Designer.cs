namespace UsoListas
{
    partial class frmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbListaContatos = new System.Windows.Forms.GroupBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbDadosPessoa = new System.Windows.Forms.GroupBox();
            this.lstbContatos = new System.Windows.Forms.ListBox();
            this.lstbTelefones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.btnApagarPessoa = new System.Windows.Forms.Button();
            this.grbListaContatos.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            this.grbDadosPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaContatos
            // 
            this.grbListaContatos.BackColor = System.Drawing.Color.Khaki;
            this.grbListaContatos.Controls.Add(this.lstbContatos);
            this.grbListaContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaContatos.Location = new System.Drawing.Point(429, 12);
            this.grbListaContatos.Name = "grbListaContatos";
            this.grbListaContatos.Size = new System.Drawing.Size(482, 540);
            this.grbListaContatos.TabIndex = 0;
            this.grbListaContatos.TabStop = false;
            this.grbListaContatos.Text = "Lista de Contatos";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.Gold;
            this.grbCadastrar.Controls.Add(this.btnSalvar);
            this.grbCadastrar.Controls.Add(this.btnLimpar);
            this.grbCadastrar.Controls.Add(this.label2);
            this.grbCadastrar.Controls.Add(this.label1);
            this.grbCadastrar.Controls.Add(this.txtEndereco);
            this.grbCadastrar.Controls.Add(this.txtNome);
            this.grbCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(12, 12);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(411, 221);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar Pessoa";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 126);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(399, 29);
            this.txtEndereco.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(321, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 46);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(228, 169);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 46);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grbDadosPessoa
            // 
            this.grbDadosPessoa.BackColor = System.Drawing.Color.Goldenrod;
            this.grbDadosPessoa.Controls.Add(this.btnAdicionarTelefone);
            this.grbDadosPessoa.Controls.Add(this.btnApagarPessoa);
            this.grbDadosPessoa.Controls.Add(this.btnEditarPessoa);
            this.grbDadosPessoa.Controls.Add(this.label6);
            this.grbDadosPessoa.Controls.Add(this.label5);
            this.grbDadosPessoa.Controls.Add(this.label4);
            this.grbDadosPessoa.Controls.Add(this.label3);
            this.grbDadosPessoa.Controls.Add(this.lstbTelefones);
            this.grbDadosPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoa.Location = new System.Drawing.Point(12, 239);
            this.grbDadosPessoa.Name = "grbDadosPessoa";
            this.grbDadosPessoa.Size = new System.Drawing.Size(411, 313);
            this.grbDadosPessoa.TabIndex = 2;
            this.grbDadosPessoa.TabStop = false;
            this.grbDadosPessoa.Text = "Dados da Pessoa";
            // 
            // lstbContatos
            // 
            this.lstbContatos.FormattingEnabled = true;
            this.lstbContatos.ItemHeight = 24;
            this.lstbContatos.Location = new System.Drawing.Point(6, 26);
            this.lstbContatos.Name = "lstbContatos";
            this.lstbContatos.Size = new System.Drawing.Size(470, 508);
            this.lstbContatos.TabIndex = 0;
            // 
            // lstbTelefones
            // 
            this.lstbTelefones.FormattingEnabled = true;
            this.lstbTelefones.ItemHeight = 24;
            this.lstbTelefones.Location = new System.Drawing.Point(6, 104);
            this.lstbTelefones.Name = "lstbTelefones";
            this.lstbTelefones.Size = new System.Drawing.Size(399, 148);
            this.lstbTelefones.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "label5";
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditarPessoa.Location = new System.Drawing.Point(179, 271);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(131, 36);
            this.btnEditarPessoa.TabIndex = 3;
            this.btnEditarPessoa.Text = "Apagar";
            this.btnEditarPessoa.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(6, 271);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(167, 36);
            this.btnAdicionarTelefone.TabIndex = 3;
            this.btnAdicionarTelefone.Text = "Novo Telefone";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = false;
            // 
            // btnApagarPessoa
            // 
            this.btnApagarPessoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnApagarPessoa.Location = new System.Drawing.Point(316, 271);
            this.btnApagarPessoa.Name = "btnApagarPessoa";
            this.btnApagarPessoa.Size = new System.Drawing.Size(89, 36);
            this.btnApagarPessoa.TabIndex = 3;
            this.btnApagarPessoa.Text = "Editar";
            this.btnApagarPessoa.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(923, 564);
            this.Controls.Add(this.grbDadosPessoa);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.grbListaContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmInicio";
            this.Text = "Agenda InovTec";
            this.grbListaContatos.ResumeLayout(false);
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbDadosPessoa.ResumeLayout(false);
            this.grbDadosPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListaContatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox grbDadosPessoa;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.ListBox lstbContatos;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstbTelefones;
        private System.Windows.Forms.Button btnApagarPessoa;
    }
}

