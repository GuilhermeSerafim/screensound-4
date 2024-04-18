// Esse using tem um contexto diferente - Gerenciar recurso
using (HttpClient client = new())
{
    // Recurso
    try
    {

        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso"); // Utilizamos o async, pois não sabemos quantas músicas tem
        Console.WriteLine(resposta); // Dados da api
    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema: " + ex.Message);
    }

    // Liberar Recurso
}
