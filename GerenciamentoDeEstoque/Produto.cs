using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    public class Produto
    {
        private static int UltimoId = 0;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double Preco { get; set; }
        public string LocalizacaoDeposito { get; set; }


        public List<String> HistoricoMovimentacoes { get; set; } = new List<String>();

        public Produto()
        {
            Id = ++UltimoId;
        }

        public Produto(string nome, string categoria, int quantidadeEstoque, double preco, string localizacaoDeposito)
        {
            Id = ++UltimoId;
            Nome = nome;
            Categoria = categoria;
            QuantidadeEstoque = quantidadeEstoque;
            Preco = preco;
            LocalizacaoDeposito = localizacaoDeposito;
        }
    }
}
