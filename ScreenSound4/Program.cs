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
        //musicas[1998].ExibirInfoMusica();
        // Desafio 1 - Exibir todos os generos de musicas da lista
        //Musica.FiltrarEExibirTodosGenerosMusicaisUnicos(musicas); // Solução mais eficiente
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); // Solução moderna
        LinqOrder.ExibirArtistasOrdenados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }
}