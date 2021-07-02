using System;
using System.Collections.Generic;

namespace App.Localiza
{
    public class Divisores
    {
        public List<int> Divisor { get; private set; }

        public void AdicionaDivisores(int num)
        {
            Divisor = GetAllDivisores(num);
        }
        private static List<int> GetAllDivisores(int num)
        {
            List<int> lista = new List<int> { 1, num };
            Console.WriteLine("Os divisores do numero {0} são:", num);

            for (int divisor = 2; divisor <= (num / 2); divisor++)
            {
                if ((num % divisor) == 0)
                {
                    lista.Add(divisor);
                }
            }
            lista.Sort();
            lista.ForEach(action => { Console.Write(" {0} ", action); });
            return lista;
        }
    }
}