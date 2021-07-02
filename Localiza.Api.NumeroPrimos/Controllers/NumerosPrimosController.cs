using Localiza.Api.NumeroPrimos.Interfaces;
using Localiza.Api.NumeroPrimos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumeroPrimos.Controllers
{
    public class NumerosPrimosController : ControllerBase
    {
        private readonly IServicePrimos _repo;

        public NumerosPrimosController(IServicePrimos servicePrimos)
        {
            this._repo = servicePrimos;
        }

        [HttpPost, Route("api/NumerosPrimos")]
        public IActionResult NumerosPrimos([FromBody] Primos num)
        {
            if (num == null)
                return BadRequest();

            if (num.Divisores == null || !num.Divisores.Any())
            {
                return BadRequest("A sua lista de divisores está vazia!");
            }

            var result = _repo.ListaPrimos(num.Divisores.ToList());
            return Ok(result);
        }
    }
}
