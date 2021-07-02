using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Interfaces
{
    public interface INumerosSearchService
    {
        Task<(bool IsSuccess, dynamic ListaNumeros, string ErrorMessage)> GetListaNumeros(int num);
    }
}
