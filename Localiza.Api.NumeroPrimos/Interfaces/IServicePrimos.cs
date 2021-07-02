using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumeroPrimos.Interfaces
{
    public interface IServicePrimos
    {
        public List<int> ListaPrimos(List<int> lista);
    }
}
