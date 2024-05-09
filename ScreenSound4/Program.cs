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

        MusicasPreferidas musicasPreferidasGui = new("Ana");
        //musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1901]);
        //musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1801]);
        //musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1701]);
        //musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1601]);
        //musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1501]); // Tem que colocar exatamente 5 musicas

        //musicasPreferidasGui.ExibirMusicasFavoritas();
        //musicasPreferidasGui.GerarArquivoJsonComAsMusicas();
        musicas[77].ExibirInfoMusica();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }
}