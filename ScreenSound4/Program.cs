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

//        MusicasPreferidas musicasPreferidasGui = new("Guilherme");
//        musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1900]);
//        musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1800]);
//        musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1700]);
//        musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1600]);
//        musicasPreferidasGui.AdicionarMusicasFavoritas(musicas[1500]); // Tem que colocar exatamente 5 musicas

//        musicasPreferidasGui.ExibirMusicasFavoritas();
//        musicasPreferidasGui.GerarArquivoJson();

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Temos um problema: " + ex.Message);
//    }
//}

// Desafios + sobre serialização, desserialização e criação de arquivos
// Desafio 1

//Console.Write("Digite seu nome: ");
//string nome = Console.ReadLine()!;
//Console.Write("Digite sua idade: ");
//string idade = Console.ReadLine()!;
//Console.Write("Digite seu e-mail: ");
//string email = Console.ReadLine()!;
//Console.WriteLine("\nGerando arquivo...");
//Thread.Sleep(1500);
//string nomeDoArquivo = $"data-{email}";
//string dados = JsonSerializer.Serialize(new
//{
//    nome = nome,
//    idade = idade,
//    email = email,
//});
//File.WriteAllText(nomeDoArquivo, dados);
//Console.WriteLine($"\nArquivo gerado no caminho {Path.GetFullPath(nomeDoArquivo)}");

using ScreenSound4.Desafio.SerializarEDesserializar;
using System.Runtime.CompilerServices;
using System.Text.Json;
// Desafio 2
// Nome do arquivo para ler
//string fileName = "pessoa.json";

//// Verificar se o arquivo existe
//if (File.Exists(fileName))
//{
//    // Ler conteúdo do arquivo JSON
//    string jsonString = File.ReadAllText(fileName);

//    // Desserializar JSON para objeto Pessoa
//    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString)!;

//    // Exibir informações da pessoa
//    Console.WriteLine($"Nome: {pessoa.Nome}");
//    Console.WriteLine($"Idade: {pessoa.Idade}");
//    Console.WriteLine($"E-mail: {pessoa.Email}");
//}
//else
//{
//    Console.WriteLine($"O arquivo {fileName} não existe.");
//}

// Desafio 3
// Criar uma lista de pessoas
//List<Pessoa> pessoas = new List<Pessoa>();

//// Permitir ao usuário inserir informações de várias pessoas
//while (true)
//{
//    Pessoa pessoa = new Pessoa();
//    Console.Write("Digite o nome (ou 'sair' para encerrar): ");
//    string nome = Console.ReadLine();

//    if (nome.ToLower() == "sair")
//        break;

//    pessoa.Nome = nome;

//    Console.Write("Digite a idade: ");
//    pessoa.Idade = int.Parse(Console.ReadLine());

//    Console.Write("Digite o e-mail: ");
//    pessoa.Email = Console.ReadLine();

//    // Adicionar pessoa à lista
//    pessoas.Add(pessoa);
//}

//// Serializar a lista em JSON
//string jsonString = JsonSerializer.Serialize(pessoas);

//// Nome do arquivo para salvar
//string fileName = "pessoas.json";

//// Escrever JSON no arquivo
//File.WriteAllText(fileName, jsonString);

//Console.WriteLine($"Os dados foram salvos em {fileName}");


// Desafio 4
if(File.Exists("pessoas.json"))
{
    // Ler conteúdo do arquivo JSON
    string jsonString = File.ReadAllText("pessoas.json");
    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString)!;
    foreach(var pessoa in pessoas)
    {
        Console.WriteLine(pessoa.Nome + " - " + pessoa.Email);
    }
}

// Desafio 5
// Nome do arquivo para ler
string fileName = "pessoas.json";

// Verificar se o arquivo existe
if (File.Exists(fileName))
{
    // Ler conteúdo do arquivo JSON
    string jsonString = File.ReadAllText(fileName);

    // Desserializar JSON para lista de pessoas
    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

    // Permitir ao usuário inserir uma idade
    Console.Write("Digite a idade para buscar pessoas: ");
    int idadeParaBuscar = int.Parse(Console.ReadLine());

    // Filtrar pessoas com a idade especificada
    List<Pessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

    if (pessoasComIdade.Any()) // Verifica se na lista possui algum elemento (não nulez)
    {
        // Exibir informações das pessoas com a idade especificada
        Console.WriteLine($"Pessoas com {idadeParaBuscar} anos:");

        foreach (Pessoa pessoa in pessoasComIdade)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
        }
    }
    else
    {
        Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} anos.");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}