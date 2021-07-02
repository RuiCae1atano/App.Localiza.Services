using System;
using System.Collections.Generic;

namespace App.Localiza
{
    class Program : SolicitacaoPrimos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com um numero: ");
            var n = int.Parse(Console.ReadLine());

            //2 Criar a lista de divisores
            Divisores divisores = new Divisores();
            divisores.AdicionaDivisores(n);

            //3-Checkar se exister primos
            SolicitacaoPrimos primos = new SolicitacaoPrimos();
            primos.AdicionaDivisores(divisores.Divisor);

        }
    }
}
