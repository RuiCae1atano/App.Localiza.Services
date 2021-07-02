using Localiza.Api.Numeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Interfaces
{
    public interface IPrimosService
    {
        Task<(bool IsSuccess, List<int> ListaPrimos, string ErrorMessage)> GetListaPrimosAsync(Primos listaDivisores);
    }
}
