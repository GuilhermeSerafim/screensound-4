using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.ModelarESerializar
{
    internal class Carro
    {
        [JsonPropertyName("marca")]
        public string Marca { get; set; }
        [JsonPropertyName("modelo")]
        public string Modelo { get; set; }
        [JsonPropertyName("ano")]
        public int Ano { get; set; }
        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }
        [JsonPropertyName("motor")]
        public string Motor { get; set; }
        [JsonPropertyName("transmissao")]
        public string Transmissao { get; set; }
    }
}
