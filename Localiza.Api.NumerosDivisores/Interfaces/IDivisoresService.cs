using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumerosDivisores.Interfaces
{
    public interface IDivisoresService
    {
        public List<int> GetAllDivisores(int num);
    }
}
