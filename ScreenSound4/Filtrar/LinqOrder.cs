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
        List<string> artistasOrdenados = musicas.OrderBy(musica => musica.Artista) // APENAS Ordenação
            .Select(musica => musica.Artista) // Extração dos artistas
            .Distinct() // Tirar repetido
            .ToList()!; // Colocando em uma lista de string

        Console.WriteLine("Lista de artistas ordenados: ");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
