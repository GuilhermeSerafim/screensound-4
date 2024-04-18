using System.Text.Json.Serialization;

namespace ScreenSound4.Model;

internal class Musica
{
    // Metadado
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirInfoMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Genêro musical: {Genero}");
        Console.WriteLine($"Duracao: {Duracao / 1000}");
    }
    public static void ExibirTodosGenerosMusicais(List<Musica> musicas)
    {
        // Extraindo musicas para genero unico
        // Criar um HashSet para armazenar gêneros musicais únicos
        HashSet<string> generosUnicos = new HashSet<string>();
        // Percorrer todas as musicas
        foreach(Musica musica in musicas)
        {

            // Antes de adicionar a musica ao genero unico, preciso realizar alguns procedimentos
            generosUnicos.Add(musica.Genero!);
        }
        // Após abstrair os generos vou exibir no console, ou retornar dependendo da proposta
        Console.WriteLine("Todos os generos musicais: ");
        // Extraindo musicas para albuns
        foreach (var genero in generosUnicos)
        {
            Console.WriteLine(genero);
            Console.WriteLine();
        }
    }
}
