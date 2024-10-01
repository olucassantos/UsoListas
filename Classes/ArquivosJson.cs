using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoListas.Classes
{
    internal class ArquivosJson
    {
        private static string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pessoas.json");

        public static void ExportarPessoasParaJson(List<Pessoa> listaPessoas)
        {
            if (File.Exists(caminhoArquivo))
            {
                // Limpa os dados
                File.WriteAllText(caminhoArquivo, string.Empty);
            }
            else
            {
                // Cria um arquivo
                using (FileStream fileStream = File.Create(caminhoArquivo))
                {
                    fileStream.Close();
                }
            }

            // Transforma a lista em dados JSON
            string dadosJson = JsonConvert.SerializeObject(listaPessoas, Formatting.Indented);

            // Escreve a lista dentro do arquivo
            File.WriteAllText(caminhoArquivo, dadosJson);
        }

        public static List<Pessoa> ImportarPessoasJson()
        {
            if (File.Exists(caminhoArquivo))
            {
                // Le os dados do arquivo json
                string dadosJson = File.ReadAllText(caminhoArquivo);

                List<Pessoa> listaPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dadosJson);

                return listaPessoas;
            }
            else
            {
                // Caso não tenha o arquivo, retorna uma lista em branco
                return new List<Pessoa>();
            }
        }
    }
}
