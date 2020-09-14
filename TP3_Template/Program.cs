using System;
using System.Collections.Generic;
using System.Globalization;
using TP3_Modelo;

namespace TP3_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            // Método Main: O fluxo principal do programa.
            RepositorioPessoas.Pessoas = new List<Pessoa>();
            while (true)
            {
                // 1º passo do fluxo principal: Exibir o menu.
                ExibirMenu();
                // 2º passo do fluxo principal: Solicitar ao usuário a opção desejada.
                var opcao = Int32.Parse(Console.ReadLine());
                // 3º passo do fluxo principal: Executar a opção desejada.
                ExecutarSelecao(opcao);
            }
        }

        private static void ExecutarSelecao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    //Pesquisar pessoa.
                    Console.Clear();
                    Console.WriteLine("Procurar pessoa");
                    Console.WriteLine("Informe o nome da pessoa: ");
                    var busca = Console.ReadLine();
                    var resultados = RepositorioPessoas.BuscarPessoa(busca);
                    //Iterar a lista de resultados, imprimindo-os.
                    Console.Clear();
                    Console.WriteLine("Resultados de busca:");
                    int i = 0;
                    foreach(var p in resultados)
                    {
                        Console.WriteLine($"{i} — {p.Nome} {p.Sobrenome}");
                        i++;
                    }
                    Console.Write("Selecione uma pessoa da lista acima: ");
                    var selecao = Int32.Parse(Console.ReadLine());
                    // Imprimir nome, sobrenome, aniversário, quantos dias faltam etc. para o resultado escolhido:
                    var pessoaEscolhida = resultados[selecao];
                    Console.WriteLine($"{pessoaEscolhida.Nome} {pessoaEscolhida.Sobrenome}");
                    var diasAniversario = pessoaEscolhida.CalcularDiasProximoAniversario();
                    if (diasAniversario == 0)
                    {
                        Console.WriteLine(pessoaEscolhida.Parabens());
                    } else
                    {
                        Console.WriteLine($"Faltam {diasAniversario} dias para o próximo aniversário.");
                    }
                    Console.ReadKey(); // "Macete" — método que lê uma tecla qualquer, só para esperar você digitar algo antes do break abaixo.
                    break;
                case 2:
                    //Inserir pessoa.
                    Console.Clear();
                    Console.WriteLine("Adicionar nova pessoa");
                    Console.WriteLine("Informe o nome da pessoa: ");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Informe o sobrenome da pessoa: ");
                    var sobrenome = Console.ReadLine();
                    Console.WriteLine("Informe a data de nascimento: ");
                    var data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));
                    Pessoa pessoa = new Pessoa() { Nome = nome, Sobrenome = sobrenome, DataNascimento = data };
                    RepositorioPessoas.InserirPessoa(pessoa);
                    break;
                case 3:
                    //Sair do programa.
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Gerenciador de Aniversários");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar pessoas");
            Console.WriteLine("2 - Adicionar nova pessoa");
            Console.WriteLine("3 - Sair");
        }
    }
}
