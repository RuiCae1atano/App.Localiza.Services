using Localiza.Api.NumerosDivisores.Interfaces;
using Localiza.Api.NumerosDivisores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumerosDivisores.Services
{
    public class DivisoresService : IDivisoresService
    {

        public List<int> GetAllDivisores(int num)
        {
            Divisores divisores = new Divisores();
            divisores.AdicionaDivisores(num);
            return divisores.Divisor;
        }
    }
}
