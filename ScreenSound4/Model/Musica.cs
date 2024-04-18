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
}
