// Esse using tem um contexto diferente - Gerenciar recurso
using System.Text.Json;
using ScreenSound4.Model;
using (HttpClient client = new())
{
    // Recurso
    try
    {
        // Utilizamos o async, pois não sabemos quantas músicas tem
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Tá tudo em string - dificil de manipular
        //Console.WriteLine(resposta); // Dados da api
        // Desserialização (metodo statico)
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        musicas[1998].ExibirInfoMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }

    // Liberar Recurso
}