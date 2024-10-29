using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    public class Estoque : Produto
    {
        public List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public void RegistrarEntrada(int id, int quantidade)
        {
            var produto = produtos.FirstOrDefault(x => x.Id == id);

            if (produto != null)
            {
                produto.HistoricoMovimentacoes.Add($"{DateTime.Now}: Entrada de {quantidade} unidades.");
                produto.QuantidadeEstoque += quantidade;
                Console.WriteLine("Entrada registrada");
            }
        }

        public void RegistrarSaida(int id, int quantidade)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto != null)
            {
                if (produto.QuantidadeEstoque >= quantidade)
                {
                    produto.QuantidadeEstoque -= quantidade;

                    produto.HistoricoMovimentacoes.Add($"{DateTime.Now}: Entrada de {quantidade} unidades.");
                    Console.WriteLine($"Sapida registrada: -{quantidade} unidades do produto {produto.Nome}, Estoque atualizado para: {produto.QuantidadeEstoque}");
                }
                else
                {
                    Console.WriteLine("Estoque insuficiente para realizar essa venda.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public List<Produto> ObterProdutos()
        {
            return produtos;
        }
    }
}
