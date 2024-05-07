//// Esse using tem um contexto diferente - Gerenciar recurso
//using System.Text.Json;
//using ScreenSound4.Filtrar;
//using ScreenSound4.Model;

//// Serializar -> converter objetos em uma representação JSON
//// Desserializar -> converter JSON em objetos
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
//        //Musica.FiltrarEExibirTodosGenerosMusicaisUnicos(musicas); // Solução mais eficiente
//        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); // Solução moderna
//        //LinqOrder.ExibirArtistasOrdenados(musicas);
//        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
//        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Temos um problema: " + ex.Message);
//    }
//}

using ScreenSound4;
using ScreenSound4.Desafio.Filtros;

// Desafio 1
List<int> nums = new()
{
    1,2, 3, 4, 5, 6, 7, 7, 7, 8, 9, 9, 10, 10,
};
//Numeros.FiltrarNumerosParaUnicos(nums);

// Desafio 2
Livros a = new("a", "b", 2000);
Livros b = new("a", "b", 2600);
Livros c = new("a", "b", 1000);
List<Livros> livros = new()
{
    a, b, c
};
Livros.ExibirLivrosPublicadosDepoisDe2000(livros);


// Desafio 3
Produto d = new("a", 8);
Produto e = new("b", 6);
List<Produto> produtos = new()
{
    d, e
};

Produto.CalcularMediaDePrecosDosProdutos(produtos);

// Desafio 4
List<int> num = new()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9
};
var numPares = num.Where(x => x % 2 == 0);
foreach (var p in numPares)
{
    Console.WriteLine(p);
}