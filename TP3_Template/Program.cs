using System;

namespace TP3_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            // Método Main: O fluxo principal do programa.

            // 1º passo do fluxo principal: Exibir o menu.
            ExibirMenu();
            // 2º passo do fluxo principal: Solicitar ao usuário a opção desejada.
            var opcao = Int32.Parse(Console.ReadLine());
            // 3º passo do fluxo principal: Executar a opção desejada.
            ExecutarSelecao(opcao);
        }

        private static void ExecutarSelecao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    //Pesquisar pessoa.
                    break;
                case 2:
                    //Inserir pessoa.
                    break;
                case 3:
                    //Sair do programa.
                    Console.WriteLine("Fim do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("Gerenciador de Aniversários");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar pessoas");
            Console.WriteLine("2 - Adicionar nova pessoa");
            Console.WriteLine("3 - Sair");
        }
    }
}
