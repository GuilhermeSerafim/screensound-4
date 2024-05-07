// Esse using tem um contexto diferente - Gerenciar recurso
using System.Text.Json;
using ScreenSound4.Model;
//using (HttpClient client = new())
//{
//    // Recurso
//    try
//    {
//        // Utilizamos o async, pois não sabemos quantas músicas tem
//        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//        // Desserialização (metodo estatico)
//        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Indicando que não é nulo !
//        //musicas[1998].ExibirInfoMusica();
//        // Desafio 1 - Exibir todos os generos de musicas da lista
//        Musica.ExibirTodosGenerosMusicaisUnicos(musicas);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Temos um problema: " + ex.Message);
//    }
//}

using (HttpClient cliente = new HttpClient())
{
	try
	{
		string res = await cliente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
	}
	catch (Exception ex)
	{

        Console.WriteLine("Temos um problema: " + ex.Message);
    }
}