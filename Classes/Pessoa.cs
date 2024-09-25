using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoListas.Classes
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Telefones = new List<Telefone>();
        }

        public void AdicionarTelefone(string ddd, string numero, string tipo)
        {
            try
            {
                Telefones.Add(new Telefone(ddd, numero, tipo));
            } 
            catch (ArgumentException ex) 
            { 
                // Cria uma caixa de mensagem quando o tipo é inválido
                MessageBox.Show(ex.Message, "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
