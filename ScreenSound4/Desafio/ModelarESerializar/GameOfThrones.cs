using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.ModelarESerializar
{
    internal class GameOfThrones
    {
        [JsonPropertyName("tvSeries")]
        public List<string> TvSeries { get; set; }

        public void ExibirSessoesAtuadas()
        {
            Console.WriteLine("Sessões atuadas: \n");
            foreach (string item in TvSeries)
            {
                Console.WriteLine(item + "\n");
            }
        }
    }
}
