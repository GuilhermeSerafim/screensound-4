using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.ModelarESerializar
{
    internal class Filme
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("rank")]
        public int Classificacao { get; set; }
        [JsonPropertyName("title")]
        public string Titulo { get; set; }
        [JsonPropertyName("fullTitle")]
        public string TituloCompleto { get; set; }
        [JsonPropertyName("year")]
        public int Ano { get; set; }
        [JsonPropertyName("image")]
        public string Imagem { get; set; }
        [JsonPropertyName("crew")]
        public string Equipe { get; set; }
        [JsonPropertyName("imDbRating")]
        public double Estrelas { get; set; }
        [JsonPropertyName("imDbRatingCount")]
        public int QtdEstrelas { get; set; }

    }
}
