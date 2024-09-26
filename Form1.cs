using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsoListas.Classes;

namespace UsoListas
{
    public partial class frmInicio : Form
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void LimpaCadastroContato()
        {
            txtNome.Clear();
            txtEndereco.Clear();

            // Foca no componente
            txtNome.Focus();
        }

        private void AtualizaListaContatos()
        {
            lstbContatos.Items.Clear();
            lstbContatos.Items.AddRange(listaPessoas.ToArray());
        }

        private void AtualizaListaTelefones(Pessoa pessoa)
        {
            lstbTelefones.Items.Clear();
            lstbTelefones.Items.AddRange(pessoa.Telefones.ToArray());
        }

        private void lstbContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Caso tenha algum item selecionado
            if (lstbContatos.SelectedItems != null)
            {
                Pessoa pessoaSelecionada = (Pessoa)lstbContatos.SelectedItem;

                MostraOcultaDetalhesContato(true);
                lblNomeContato.Text = pessoaSelecionada.Nome;
                lblEnderecoContato.Text = pessoaSelecionada.Endereco;
                AtualizaListaTelefones(pessoaSelecionada);
            } 
            else
            {
                MostraOcultaDetalhesContato(false);
            }
        }

        private void MostraOcultaDetalhesContato(bool visivel)
        {
            lblNomeContato.Visible = visivel;
            lblEnderecoContato.Visible = visivel;
            lstbTelefones.Visible = visivel;
            btnAdicionarTelefone.Visible = visivel;
            btnApagarPessoa.Visible = visivel;
            btnEditarPessoa.Visible = visivel;
        }


        /*
             Salva uma nova pessoa na listaPessoas.
             São utilizados os campos de nome e endereço, sendo que endereço é opcional.

            private List<Pessoa> listaPessoas = new List<Pessoa>();
        */
        private void SalvarContato()
        {
            // Verifica se o nome da pessoa não está em branco
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Nome é obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Instancia uma nova pessoa
            Pessoa pessoa = new Pessoa(txtNome.Text);
            pessoa.Endereco = txtEndereco.Text;

            // Insere a nova pessoa na lista de pessoas
            listaPessoas.Add(pessoa);

            MessageBox.Show($"Contato {pessoa.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaCadastroContato();
            AtualizaListaContatos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarContato();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caso a tecla pressionada seja enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                SalvarContato();
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caso a tecla pressionada seja enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                SalvarContato();
            }
        }
    }
}
