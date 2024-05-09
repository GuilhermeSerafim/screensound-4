using ScreenSound4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Filtrar;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero) // Operação LINQ
            .Distinct() // Remover duplicata
            .ToList(); // Converte os gêneros musicais distintos em uma lista.

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string generoRequerido)
    {
        // Usado para filtrar uma sequência com base em um critério específico.
        List<string> artistasPorGeneroMusical = musicas.Where(musica =>
            musica.Genero!.Contains(generoRequerido))
            .Select(musica => musica.Artista)
            .Distinct().ToList()!;

        if (artistasPorGeneroMusical.Count() > 0)
        {
            Console.WriteLine($"Exibindo os artistas do genero músical {generoRequerido}: ");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }

        }
        else
        {
            Console.WriteLine($"Gênero {generoRequerido} não encontrado");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        List<Musica> musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        if (musicasDoArtista.Count() > 0)
        {
            Console.WriteLine($"Musicas do artista {nomeDoArtista}");
            foreach (var item in musicasDoArtista)
            {
                Console.WriteLine($"- {item.Nome}");
            }
        } else
        {
            Console.WriteLine($"Artista {nomeDoArtista} não encontrado");
        }
    }
    public static void FiltrarPorAno(List<Musica> musicas, int ano)
    {
        var musicasFiltradaPorAnoDe2010 = musicas.Where(musica => int.Parse(musica.Year!) > ano).ToList();
        Console.WriteLine("Exibindo músicas do ano 2010 para cima");
        foreach (var item in musicasFiltradaPorAnoDe2010)
        {
            Console.WriteLine(item.Nome + "\n");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidadeRequirida)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals(tonalidadeRequirida))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine($"Músicas na tonalidade {tonalidadeRequirida}:\n");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
