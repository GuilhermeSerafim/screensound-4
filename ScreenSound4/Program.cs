// Esse using tem um contexto diferente - Gerenciar recurso
using System.Text.Json;
using ScreenSound4.Filtrar;
using ScreenSound4.Model;

// Serializar -> converter objetos em uma representação JSON
// Desserializar -> converter JSON em objetos
using (HttpClient client = new())
{
    // Recurso
    try
    {
        // Utilizamos o async, pois não sabemos quantas músicas tem
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Desserialização (metodo estatico)
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Indicando que não é nulo !

        MusicasPreferidas musicaPreferidasGui = new("Guilherme");
        musicaPreferidasGui.AdicionarMusicasFavoritas(musicas[1]);
        musicaPreferidasGui.AdicionarMusicasFavoritas(musicas[2]);
        musicaPreferidasGui.AdicionarMusicasFavoritas(musicas[3]);
        musicaPreferidasGui.AdicionarMusicasFavoritas(musicas[4]);
        musicaPreferidasGui.AdicionarMusicasFavoritas(musicas[5]);

        musicaPreferidasGui.ExibirMusicasFavoritas();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }
}