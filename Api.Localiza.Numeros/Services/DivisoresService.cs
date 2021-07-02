using Localiza.Api.Numeros.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Services
{
    public class DivisoresService : IDivisoresService
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly ILogger<DivisoresService> logger;

        public DivisoresService(IHttpClientFactory httpClientFactory, ILogger<DivisoresService> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.logger = logger;
        }
        public async Task<(List<int> ListaNumeros, bool IsSuccess, string ErrorMessage)> GetNumerosDivisoresAsync(int num)
        {
            try
            {
                var client = httpClientFactory.CreateClient("DivisoresService");
                var response = await client.GetAsync($"api/divisores/{num}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsByteArrayAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var result = JsonSerializer.Deserialize<List<int>>(content, options);
                    return (result, true, null);
                }
                return (null, false, response.ReasonPhrase);
            }
            catch (Exception ex)
            {

                logger?.LogError(ex.ToString());
                return (null, false, ex.Message);
            }
        }
    }
}
