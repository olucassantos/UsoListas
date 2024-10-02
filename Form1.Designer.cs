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
            this.lstbContatos = new System.Windows.Forms.ListBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbDadosPessoa = new System.Windows.Forms.GroupBox();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.btnApagarPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.lblEnderecoContato = new System.Windows.Forms.Label();
            this.lblNomeContato = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbTelefones = new System.Windows.Forms.ListBox();
            this.grbListaContatos.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            this.grbDadosPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaContatos
            // 
            this.grbListaContatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbListaContatos.BackColor = System.Drawing.Color.Khaki;
            this.grbListaContatos.Controls.Add(this.lstbContatos);
            this.grbListaContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaContatos.Location = new System.Drawing.Point(620, 11);
            this.grbListaContatos.Margin = new System.Windows.Forms.Padding(2);
            this.grbListaContatos.Name = "grbListaContatos";
            this.grbListaContatos.Padding = new System.Windows.Forms.Padding(2);
            this.grbListaContatos.Size = new System.Drawing.Size(511, 631);
            this.grbListaContatos.TabIndex = 0;
            this.grbListaContatos.TabStop = false;
            this.grbListaContatos.Text = "Lista de Contatos";
            // 
            // lstbContatos
            // 
            this.lstbContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbContatos.FormattingEnabled = true;
            this.lstbContatos.ItemHeight = 17;
            this.lstbContatos.Location = new System.Drawing.Point(4, 20);
            this.lstbContatos.Margin = new System.Windows.Forms.Padding(2);
            this.lstbContatos.Name = "lstbContatos";
            this.lstbContatos.Size = new System.Drawing.Size(503, 599);
            this.lstbContatos.TabIndex = 5;
            this.lstbContatos.SelectedIndexChanged += new System.EventHandler(this.lstbContatos_SelectedIndexChanged);
            this.lstbContatos.DoubleClick += new System.EventHandler(this.lstbContatos_DoubleClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCadastrar.BackColor = System.Drawing.Color.Gold;
            this.grbCadastrar.Controls.Add(this.btnSalvar);
            this.grbCadastrar.Controls.Add(this.btnLimpar);
            this.grbCadastrar.Controls.Add(this.label2);
            this.grbCadastrar.Controls.Add(this.label1);
            this.grbCadastrar.Controls.Add(this.txtEndereco);
            this.grbCadastrar.Controls.Add(this.txtNome);
            this.grbCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(9, 8);
            this.grbCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Padding = new System.Windows.Forms.Padding(2);
            this.grbCadastrar.Size = new System.Drawing.Size(607, 147);
            this.grbCadastrar.TabIndex = 0;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar Pessoa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(449, 113);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(529, 113);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 31);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(4, 84);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(599, 23);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(4, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(599, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // grbDadosPessoa
            // 
            this.grbDadosPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosPessoa.BackColor = System.Drawing.Color.Goldenrod;
            this.grbDadosPessoa.Controls.Add(this.btnAdicionarTelefone);
            this.grbDadosPessoa.Controls.Add(this.btnApagarPessoa);
            this.grbDadosPessoa.Controls.Add(this.btnEditarPessoa);
            this.grbDadosPessoa.Controls.Add(this.lblEnderecoContato);
            this.grbDadosPessoa.Controls.Add(this.lblNomeContato);
            this.grbDadosPessoa.Controls.Add(this.label4);
            this.grbDadosPessoa.Controls.Add(this.label3);
            this.grbDadosPessoa.Controls.Add(this.lstbTelefones);
            this.grbDadosPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoa.Location = new System.Drawing.Point(9, 159);
            this.grbDadosPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.grbDadosPessoa.Name = "grbDadosPessoa";
            this.grbDadosPessoa.Padding = new System.Windows.Forms.Padding(2);
            this.grbDadosPessoa.Size = new System.Drawing.Size(607, 481);
            this.grbDadosPessoa.TabIndex = 2;
            this.grbDadosPessoa.TabStop = false;
            this.grbDadosPessoa.Text = "Dados da Pessoa";
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarTelefone.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(268, 412);
            this.btnAdicionarTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(131, 63);
            this.btnAdicionarTelefone.TabIndex = 6;
            this.btnAdicionarTelefone.Text = "Novo Telefone";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = false;
            this.btnAdicionarTelefone.Visible = false;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click);
            // 
            // btnApagarPessoa
            // 
            this.btnApagarPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarPessoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApagarPessoa.Location = new System.Drawing.Point(518, 412);
            this.btnApagarPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarPessoa.Name = "btnApagarPessoa";
            this.btnApagarPessoa.Size = new System.Drawing.Size(85, 63);
            this.btnApagarPessoa.TabIndex = 8;
            this.btnApagarPessoa.Text = "Apagar";
            this.btnApagarPessoa.UseVisualStyleBackColor = false;
            this.btnApagarPessoa.Visible = false;
            this.btnApagarPessoa.Click += new System.EventHandler(this.btnApagarPessoa_Click);
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarPessoa.Location = new System.Drawing.Point(406, 412);
            this.btnEditarPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(105, 63);
            this.btnEditarPessoa.TabIndex = 7;
            this.btnEditarPessoa.Text = "Editar";
            this.btnEditarPessoa.UseVisualStyleBackColor = false;
            this.btnEditarPessoa.Visible = false;
            this.btnEditarPessoa.Click += new System.EventHandler(this.btnEditarPessoa_Click);
            // 
            // lblEnderecoContato
            // 
            this.lblEnderecoContato.AutoSize = true;
            this.lblEnderecoContato.Location = new System.Drawing.Point(94, 43);
            this.lblEnderecoContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnderecoContato.Name = "lblEnderecoContato";
            this.lblEnderecoContato.Size = new System.Drawing.Size(52, 17);
            this.lblEnderecoContato.TabIndex = 2;
            this.lblEnderecoContato.Text = "label5";
            this.lblEnderecoContato.Visible = false;
            // 
            // lblNomeContato
            // 
            this.lblNomeContato.AutoSize = true;
            this.lblNomeContato.Location = new System.Drawing.Point(63, 25);
            this.lblNomeContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeContato.Name = "lblNomeContato";
            this.lblNomeContato.Size = new System.Drawing.Size(52, 17);
            this.lblNomeContato.TabIndex = 2;
            this.lblNomeContato.Text = "label5";
            this.lblNomeContato.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // lstbTelefones
            // 
            this.lstbTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbTelefones.FormattingEnabled = true;
            this.lstbTelefones.ItemHeight = 17;
            this.lstbTelefones.Location = new System.Drawing.Point(4, 69);
            this.lstbTelefones.Margin = new System.Windows.Forms.Padding(2);
            this.lstbTelefones.Name = "lstbTelefones";
            this.lstbTelefones.Size = new System.Drawing.Size(599, 327);
            this.lstbTelefones.TabIndex = 0;
            this.lstbTelefones.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1142, 653);
            this.Controls.Add(this.grbDadosPessoa);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.grbListaContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda InovTec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
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
        private System.Windows.Forms.Label lblEnderecoContato;
        private System.Windows.Forms.Label lblNomeContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstbTelefones;
        private System.Windows.Forms.Button btnApagarPessoa;
    }
}

