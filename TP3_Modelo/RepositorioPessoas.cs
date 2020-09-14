using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Modelo
{
    public class RepositorioPessoas
    {
        public static List<Pessoa> Pessoas { get; set; }

        public static List<Pessoa> BuscarPessoa(string busca)
        {
            List<Pessoa> resultados = new List<Pessoa>();
            // TODO: Lógica da busca.
            foreach(var p in Pessoas)
            {
                var nomeCompleto = $"{p.Nome} {p.Sobrenome}";
                if (nomeCompleto.Contains(busca))
                {
                    resultados.Add(p);
                }
            }

            return resultados;
        }

        public static void InserirPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            // Para o AT: Adicionar também ao arquivo
        }

        public List<Pessoa> LerArquivo(string caminhoArquivo)
        {
            return new List<Pessoa>();
        }
    }
}
