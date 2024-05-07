using ScreenSound4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Filtrar;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        List<string> artistasOrdenados = musicas.OrderBy(musica => musica.Artista) // LINQ Ordenação crescente pela prop Artista
            .Select(musica => musica.Artista) // A partir do resultado, seleciono uma parte da lista de musicas, no caso a prop Artista
            .Distinct() // Tirar repetido
            .ToList()!; // Colocando em uma lista de string

        Console.WriteLine("Lista de artistas ordenados: ");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
