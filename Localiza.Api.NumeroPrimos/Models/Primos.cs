using Localiza.Api.NumeroPrimos.Core.ExtensionMethods;
using Localiza.Api.NumerosDivisores.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumeroPrimos.Models
{
    public class Primos
    {
        public IEnumerable<int> Divisores{ get; set; }
        public List<int> Primo { get; private set; }

        public void AdicionaPrimos(List<int> lista)
        {
            Primo = ListaPrimos(lista);
        }
        private static List<int> ListaPrimos(List<int> lista)
        {
            if (lista.Count <= 0)
                throw new BusinessRuleException("Erro a lista não pode ser vazia");

            var result = new List<int>();
            Console.WriteLine("\nOs numeros primos sao: ");
            foreach (var item in lista)
            {
                if (item.EhPrimo())
                    result.Add(item);
            }
            return result;
        }
    }
}
