using Localiza.Api.NumeroPrimos.Interfaces;
using Localiza.Api.NumeroPrimos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumeroPrimos.Services
{
    public class ServicePrimos : IServicePrimos
    {
        public List<int> ListaPrimos(List<int> lista)
        {
            var primos = new Primos();
            primos.AdicionaPrimos(lista);
            return primos.Primo;
        }
    }
}
