using Localiza.Api.Numeros.Interfaces;
using Localiza.Api.Numeros.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Localiza.Api.Numeros.Services
{
    public class PrimosService : IPrimosService
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly ILogger<PrimosService> logger;

        public PrimosService(IHttpClientFactory httpClientFactory, ILogger<PrimosService> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.logger = logger;
        }

        public async Task<(bool IsSuccess, List<int> ListaPrimos, string ErrorMessage)> GetListaPrimosAsync(Primos listaDivisores)
        {
            try
            {
                var client = httpClientFactory.CreateClient("PrimosService");
                string json = JsonConvert.SerializeObject(listaDivisores);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"api/NumerosPrimos", httpContent);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var result = System.Text.Json.JsonSerializer.Deserialize<List<int>>(content, options);
                    return (true, result, null);
                }
                return (false, null, response.ReasonPhrase);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());
                return (false, null, ex.Message);
            }
        }
    }
}
