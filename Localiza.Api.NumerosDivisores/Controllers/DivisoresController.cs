using Localiza.Api.NumerosDivisores.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumerosDivisores.Controllers
{
    public class DivisoresController : ControllerBase
    {
        private readonly IDivisoresService _repo;

        public DivisoresController(IDivisoresService divisoresService)
        {
            this._repo = divisoresService;
        }

        [HttpGet, Route("api/divisores/{num}")]
        public List<int> GetDivisores(int num) 
        {
            var result = _repo.GetAllDivisores(num);
            return result;
        }
    }
}
