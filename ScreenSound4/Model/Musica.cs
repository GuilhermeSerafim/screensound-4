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

    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }


    public void ExibirInfoMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Genêro musical: {Genero}");
        Console.WriteLine($"Duracao: {Duracao / 1000}");
        Console.WriteLine($"Tonalidade da música: {Tonalidade}");
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
