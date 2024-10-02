using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoListas
{
    public partial class FrmEditarPessoa : Form
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        // Metodo construtor
        public FrmEditarPessoa(string nome, string endereco)
        {
            InitializeComponent();
            this.Nome = nome;
            this.Endereco = endereco;
        }

        private void FrmEditarPessoa_Load(object sender, EventArgs e)
        {
            txtNome.Text = Nome;
            txtEndereco.Text = Endereco;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar as informações
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show(
                    "Nome é obrigatório", 
                    "Validação", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                );

                return; // Encerra a função
            }

            // Atribuir aos atributos
            Nome = txtNome.Text;
            Endereco = txtEndereco.Text;

            // Definir o resultado como OK
            this.DialogResult = DialogResult.OK;

            // Fechar o formulário
            this.Close();
        }
    }
}
