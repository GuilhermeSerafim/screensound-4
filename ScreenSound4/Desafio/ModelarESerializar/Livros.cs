using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.ModelarESerializar
{
    internal class Livros
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }
        [JsonPropertyName("autor")]
        public string Autor { get; set; }
        [JsonPropertyName("ano_publicacao")]
        public int AnoPublicado { get; set; }
        [JsonPropertyName("genero")]
        public string Genero { get; set; }
        [JsonPropertyName("paginas")]
        public int Paginas { get; set; }
        [JsonPropertyName("editora")]
        public string Editora { get; set; }
    }
}
