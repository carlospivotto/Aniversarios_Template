using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Modelo
{
    public class RepositorioPessoas
    {
        public List<Pessoa> Pessoas { get; set; }

        public RepositorioPessoas()
        {
            Pessoas = new List<Pessoa>();
        }

        public List<Pessoa> BuscarPessoa(string nome)
        {
            List<Pessoa> resultados = new List<Pessoa>();

            // TODO: Lógica da busca.

            return resultados;
        }

        public void InserirPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }
    }
}
