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
        // Desserialização (metodo estatico)
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Indicando que não é nulo !
        //musicas[1998].ExibirInfoMusica();
        Musica.ExibirTodosGenerosMusicais(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }

    // Liberar Recurso
}
// Embora o código fornecido não inclua uma operação explícita de serialização, a função JsonSerializer pode ser usada tanto
// para serializar (converter objetos em uma representação JSON) quanto para desserializar (converter JSON em objetos).

// Desafio 1 - Exibir todos os generos de musicas da lista

