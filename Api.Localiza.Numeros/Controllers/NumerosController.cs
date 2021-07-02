using Localiza.Api.Numeros.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Localiza.Numeros.Controllers
{

    public class NumerosController : ControllerBase
    {

        private readonly ILogger<NumerosController> _logger;
        private readonly INumerosSearchService numerosService;

        public NumerosController(ILogger<NumerosController> logger, INumerosSearchService numerosService)
        {
            _logger = logger;
            this.numerosService = numerosService;
        }

        [HttpGet, Route("numeros/{num}")]
        public async Task<IActionResult> GetNumeros(int num) 
        {
            var query = await numerosService.GetListaNumeros(num);
            if (query.IsSuccess)
            {
                return Ok(query.ListaNumeros);
            }
            return NotFound();
        }

    }
}
