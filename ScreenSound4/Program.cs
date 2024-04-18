//// Esse using tem um contexto diferente - Gerenciar recurso
//using (HttpClient client = new())
//{
//    // Recurso
//    try
//    {

//        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); // Utilizamos o async, pois não sabemos quantas músicas tem
//        Console.WriteLine(resposta); // Dados da api
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Temos um problema: " + ex.Message);
//    }

//    // Liberar Recurso
//}

// Desafios aula 01
//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//        Console.WriteLine(resposta);
//    } catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY");
        Console.WriteLine(resposta);
    }
    catch (Exception e)
    {

        Console.WriteLine(e.Message);
    }
}
//try
//{
//    Console.WriteLine("Digite o primeiro numero: ");
//    int a = int.Parse(Console.ReadLine()!);
//    Console.WriteLine("Digite o segundo numero: ");
//    int b = int.Parse(Console.ReadLine()!);
//    Console.WriteLine("\n" + a / b);
//}
//catch (Exception e)
//{
//    Console.WriteLine("\n" + e.Message);
//}

//List<int> ints = new List<int>();
//ints.Add(1);
//ints.Add(2);
//ints.Add(3);
//ints.Add(4);  //[3]

//try
//{
//    Console.WriteLine(ints[4]);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    MinhaClasse objetoNulo = null;
//    objetoNulo.MeuMetodo();
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine($"Erro: {ex.Message}");
//}