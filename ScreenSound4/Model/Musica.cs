using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScreenSound4.Model;

internal class Musica
{
    // Metadado
    [JsonPropertyName("song")] // Esse nome tem que ser da api
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int? NotaDaMusicaEmNumero;

    public string? NotaDaMusica =>
        NotaDaMusicaEmNumero == 1 ? "C" :
        NotaDaMusicaEmNumero == 2 ? "C#" :
        NotaDaMusicaEmNumero == 3 ? "D" :
        NotaDaMusicaEmNumero == 4 ? "E" : "F";

    public void ExibirInfoMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Genêro musical: {Genero}");
        Console.WriteLine($"Duracao: {Duracao / 1000}");
        Console.WriteLine($"Nota da música: {NotaDaMusica}");
    }
    public static void FiltrarEExibirTodosGenerosMusicaisUnicos(List<Musica> musicas)
    {
        // Para armazenar gêneros musicais únicos
        HashSet<string> generosUnicos = new HashSet<string>();

        // Percorrer todas as musicas
        foreach (Musica musica in musicas)
        {
            // Dividir a string de gêneros em um array usando a vírgula como separador
            string[] generos = musica.Genero!.Split(',');

            // Percorrer generos para remover espaços em branco ao redor de cada gênero e adicionar ao HashSet
            foreach (string genero in generos)
            {
                // O método Trim() em C# remove caracteres específicos de uma string. Por padrão, ele remove caracteres de espaço em branco
                // E caracteres de controle Unicode do início e do final da string. 
                string generoSemEspaços = genero.Trim();

                if (!(generoSemEspaços == "set()")) // Tratando spring do python
                {
                    // Cada gênero é adicionado ao HashSet após remover espaços em branco ao redor.
                    generosUnicos.Add(generoSemEspaços);
                }
            }
        }

        // Exibição
        Console.WriteLine("Todos os generos musicais: \n");
        foreach (var genero in generosUnicos)
        {
            Console.WriteLine(genero);
            Console.WriteLine();
        }
    }

}
