using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoListas
{
    public partial class frmNovoTelefone : Form
    {
        public string Ddd {  get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public frmNovoTelefone()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se o DDD é valido
            if (txtDdd.Text.Length != 3)
            {
                MessageBox.Show("O campo DDD é obrigatório!");
                txtDdd.Focus();
                return;
            }

            // Verifica se o Número é valido
            if ((txtNumero.Text.Length != 8) && (txtNumero.Text.Length != 9))
            {
                MessageBox.Show("O campo número está inválido!");
                txtNumero.Focus();
                return;
            }

            // Verifica se selecionou um tipo
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo!");
                cmbTipo.Focus();
                return;
            }

            Ddd = txtDdd.Text;
            Numero = txtNumero.Text;
            Tipo = cmbTipo.SelectedItem.ToString();

            // Disparar o DialogResult como OK
            this.DialogResult = DialogResult.OK; // Marca o resultado como OK
            this.Close(); // Fecha o formulário
        }
    }
}
