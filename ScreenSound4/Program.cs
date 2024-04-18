// Esse using tem um contexto diferente - Gerenciar recurso
using (HttpClient client = new())
{
    // Recurso
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); // Utilizamos o async, pois não sabemos quantas músicas tem
    Console.WriteLine(resposta); // Dados da api

    // Liberar Recurso
}
