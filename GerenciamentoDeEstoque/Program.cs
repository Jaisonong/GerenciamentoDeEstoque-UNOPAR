using GerenciamentoDeEstoque;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto()
            {
                Nome = "Celular",
                Categoria = "Eletrônicos",
                QuantidadeEstoque = 25,
                Preco = 299.99,
                LocalizacaoDeposito = "A1"
            };

            Produto produto2 = new Produto()
            {
                Nome = "Geladeira",
                Categoria = "Eletrônicos",
                QuantidadeEstoque = 1,
                Preco = 2999.99,
                LocalizacaoDeposito = "A1"
            };

            Produto produto3 = new Produto()
            {
                Nome = "Teste",
                Categoria = "Eletrônicos",
                QuantidadeEstoque = 5,
                Preco = 2999.99,
                LocalizacaoDeposito = "A1"
            };

            Produto produto4 = new Produto()
            {
                Nome = "Teste",
                Categoria = "Eletrônicos",
                QuantidadeEstoque = 15,
                Preco = 2999.99,
                LocalizacaoDeposito = "A1"
            };


            Estoque estoque = new Estoque();
            estoque.AdicionarProduto(produto);
            estoque.AdicionarProduto(produto2);
            estoque.AdicionarProduto(produto3);
            estoque.AdicionarProduto(produto4);


            Relatorios relatorios = new Relatorios(estoque);

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Cadastrar Novo Produto");
                Console.WriteLine("2. Registrar Entrada de Produto");
                Console.WriteLine("3. Registrar Saída de Produto");
                Console.WriteLine("4. Relatório Completo");
                Console.WriteLine("5. Relatório de Baixo e Alto Estoque");
                Console.WriteLine("6. Consultar Histórico de Movimentação");
                Console.WriteLine("7. Localizar Item");
                Console.WriteLine("8. Sair");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Categoria do produto: ");
                        string categoria = Console.ReadLine();
                        Console.Write("Quantidade de estoque: ");
                        int qntEstoque = int.Parse(Console.ReadLine());
                        Console.Write("Preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Localização do depósito: ");
                        string localizacao = Console.ReadLine();

                        Produto novoProduto = new Produto(nome, categoria, qntEstoque, preco, localizacao);

                        estoque.AdicionarProduto(novoProduto);

                        break;

                    case "2":
                        Console.WriteLine("ID do produto: ");
                        int idEntrada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade a adicionar: ");
                        int qtdeEntrada = int.Parse(Console.ReadLine());

                        estoque.RegistrarEntrada(idEntrada, qtdeEntrada);
                        break;

                    case "3":
                        Console.WriteLine("ID do produto: ");
                        int idSaida = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade a adicionar: ");
                        int qtdeSaida = int.Parse(Console.ReadLine());

                        estoque.RegistrarSaida(idSaida, qtdeSaida);
                        break;

                    case "4":
                        relatorios.RelatorioCompleto();
                        break;

                    case "5":
                        relatorios.relatorioQuantidadeEstoque();
                        break;

                    case "6":
                        Console.WriteLine("ID do produto: ");
                        int idRelatorioMovimentacao = int.Parse(Console.ReadLine());
                        relatorios.RelatorioMovimentacaoDeProdutos(idRelatorioMovimentacao);
                        break;

                    case "7":
                        Console.WriteLine("ID do produto: ");
                        int idLocalizarItem = int.Parse(Console.ReadLine());
                        relatorios.LocalizarItem(idLocalizarItem);
                        break;

                    case "8":
                        Console.WriteLine("Você saiu do sistema.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            }

        }
    }
}