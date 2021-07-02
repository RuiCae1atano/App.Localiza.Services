using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Interfaces
{
    public interface IDivisoresService
    {
        Task<(List<int> ListaNumeros, bool IsSuccess, string ErrorMessage)> GetNumerosDivisoresAsync(int num);
    }
}
