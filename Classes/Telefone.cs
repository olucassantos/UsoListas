using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoListas.Classes
{
    internal class Telefone
    {
        public string Ddd {  get; set; }
        public string Numero {  get; set; }
        public string Tipo { get; set; } // Celular, Fixo, etc..

        private static readonly List<string> TiposPermitidos = new List<string>
        {
            "Celular",
            "Fixo",
            "Empresa",
            "Fax",
            "WhatsApp"
        };

        // Metodo construtor
        public Telefone(string ddd, string numero, string tipo)
        {
            // Validar o tipo de telefone informado
            if (!TiposPermitidos.Contains(tipo))
            {
                throw new ArgumentException($"Tipo de telefone '{tipo}' não é valido." +
                    $"Tipos permitidos: {string.Join(", ", TiposPermitidos)}");
            }

            Ddd = ddd;
            Numero = numero;
            Tipo = tipo;
        }

        // Substitui o método ToString padrão, para retornar em um formato utilizavel
        public override string ToString()
        {
            return $"{Tipo}: ({Ddd}) {Numero}";
        }
    }
}
