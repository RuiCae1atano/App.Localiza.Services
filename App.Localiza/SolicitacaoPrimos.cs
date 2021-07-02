using System;
using System.Collections.Generic;

namespace App.Localiza
{
    public class SolicitacaoPrimos
    {
        public List<int> Primos { get; private set; }

        public void AdicionaDivisores(List<int> lista)
        {
            ListaPrimos(lista);
        }
        private static void ListaPrimos(List<int> lista)
        {
            Console.WriteLine("\nOs numeros primos sao: ");
            foreach (var item in lista)
            {
                if (item.EhPrimo())
                    Console.Write($" {item} ");
            }
        }
    }
}