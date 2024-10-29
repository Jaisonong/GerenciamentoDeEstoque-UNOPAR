using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GerenciamentoDeEstoque
{
    public class Relatorios : Estoque
    {

        private Estoque estoque;

        public Relatorios(Estoque estoque)
        {
            this.estoque = estoque;
        }

        public void relatorioQuantidadeEstoque(int estoqueBaixo = 5, int estoqueAlto = 15)
        {
            var produtoBaixoEstoque = estoque.ObterProdutos().Where(p => p.QuantidadeEstoque <= estoqueBaixo);

            Console.WriteLine("Produto com Baixo Estoque: ");

            foreach (var produto in produtoBaixoEstoque)
            {
                Console.WriteLine($"ID: {produto.Id} " +
                    $"\nNome: {produto.Nome} " +
                    $"\nQuantidade: {produto.QuantidadeEstoque}");
                Console.WriteLine("*******************");
            }
            if (!produtoBaixoEstoque.Any())
            {
                Console.WriteLine("Todos produtos estão com o estoque adequado.");
            }

            var produtoAltoEstoque = estoque.ObterProdutos().Where(p => p.QuantidadeEstoque >= estoqueAlto);

            Console.WriteLine("\nProduto com Alto Estoque: ");
            foreach (var produto in produtoAltoEstoque)
            {
                Console.WriteLine($"ID: {produto.Id} " +
                    $"\nNome: {produto.Nome} " +
                    $"\nQuantidade: {produto.QuantidadeEstoque}");
                Console.WriteLine("*******************");
            }
            if (!produtoBaixoEstoque.Any())
            {
                Console.WriteLine("Todos produtos estão com o estoque adequado.");
            }
        }

        public void RelatorioCompleto()
        {
            Console.WriteLine("\nRelatório Completo de Estoque:");

            foreach (var produto in estoque.ObterProdutos())
            {
                Console.WriteLine($"ID: {produto.Id} " +
                    $"\nNome: {produto.Nome}" +
                    $" \nCategoria: {produto.Categoria}" +
                    $" \nQuantidade: {produto.QuantidadeEstoque}" +
                    $" \nPreço: {produto.Preco:C}" +
                    $" \nLocalização: {produto.LocalizacaoDeposito}");
                Console.WriteLine("*******************");
            }
        }

        public void LocalizarItem(int id)
        {

            var produto = estoque.ObterProdutos().FirstOrDefault(p => p.Id == id);


            if (produto != null)
            {
                Console.WriteLine("\nRelatório Completo de Estoque:");
                
                    Console.WriteLine($"\nID: {produto.Id} " +
                        $"\nNome: {produto.Nome}" +
                        $" \nCategoria: {produto.Categoria}" +
                        $" \nQuantidade: {produto.QuantidadeEstoque}" +
                        $" \nPreço: {produto.Preco:C}" +
                        $" \nLocalização: {produto.LocalizacaoDeposito}");
                    Console.WriteLine("*******************");
                
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void RelatorioMovimentacaoDeProdutos(int id)
        {
            var produto = estoque.ObterProdutos().FirstOrDefault(p => p.Id == id);

            if (produto != null && produto.HistoricoMovimentacoes.Any())
            {
                Console.WriteLine($"\nHistórico de Movimentações do Produto {produto.Nome}:");
                foreach (var movimentacao in produto.HistoricoMovimentacoes)
                {
                    Console.WriteLine(movimentacao);
                }
            }
            else
            {
                Console.WriteLine("Nenhuma movimentação encontrada ou produto não encontrado.");
            }

        }
    }
}
