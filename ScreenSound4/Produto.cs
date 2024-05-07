using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public static void CalcularMediaDePrecosDosProdutos(List<Produto> produtos)
        {
            var produtosComMedia = produtos.Average(produto => produto.Preco);
            Console.WriteLine("Media de produtos " + produtosComMedia);
        }
    }
}
