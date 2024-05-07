using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Model;

internal class MusicasPreferidas(string nome)
{
    public string Nome { get; set; } = nome;
    public List<Musica> MusicasFavoritas = new();

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        MusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Músicas favoritas de {Nome} \n");
        foreach (var musica in MusicasFavoritas)
        {
            Console.WriteLine(musica.Nome + " -> " + musica.Artista + "\n");
        }
    }
}
