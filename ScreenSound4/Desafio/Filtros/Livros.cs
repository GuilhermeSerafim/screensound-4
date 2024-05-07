using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.Filtros;

internal class Livros
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public Livros(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public static void ExibirLivrosPublicadosDepoisDe2000(List<Livros> livros)
    {
        var livrosPublicadosDepoisDe2000 = livros.Where(livro => livro.Ano > 2000).ToList();
        Console.WriteLine("Livros publicados depois do ano 2000:");
        foreach (var item in livrosPublicadosDepoisDe2000)
        {
            Console.WriteLine(item.Titulo);
        }
    }
}
