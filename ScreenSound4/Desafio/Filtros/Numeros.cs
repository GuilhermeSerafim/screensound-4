using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Desafio.Filtros
{
    internal class Numeros
    {
        public static void FiltrarNumerosParaUnicos(List<int> num)
        {
            var numFiltrados = num.Distinct().ToList();
            foreach (var i in numFiltrados)
            {
                Console.WriteLine(i);
            }
        }
    }
}
