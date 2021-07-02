using Localiza.Api.Numeros.Interfaces;
using Localiza.Api.Numeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Services
{
    public class NumerosSearchService : INumerosSearchService
    {
        private readonly IPrimosService primosService;
        private readonly IDivisoresService divisoresService;

        public NumerosSearchService(IPrimosService primosService, IDivisoresService divisoresService)
        {
            this.primosService = primosService;
            this.divisoresService = divisoresService;
        }
        public async Task<(bool IsSuccess, dynamic ListaNumeros, string ErrorMessage)> GetListaNumeros(int num)
        {
            if (num <= 0)
                throw new Exception("Numero não pode ser usado");
            var divisoresResult = await divisoresService.GetNumerosDivisoresAsync(num);
            
            if (!divisoresResult.IsSuccess)
            {
                return (false, null, "");
            }

            var divisores = new Primos { Divisores = divisoresResult.ListaNumeros};
            var primosResult = await primosService.GetListaPrimosAsync(divisores);
            if (primosResult.IsSuccess)
            {
                var result = new { Divisores = divisoresResult.ListaNumeros, Primos = primosResult.ListaPrimos };
                return (true,result,$"Divisores de {num}");
            }
            return (false, null, $"Divisores de {num} não encontrados.");


        }
    }
}
