using Localiza.Api.NumeroPrimos.Models;
using Localiza.Api.NumerosDivisores.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NumeroPrimoService
{
    public class NumerosPrimosServiceTests
    {
        [Fact]
        public void GetNumerosPrimosComListaDeNumeros()
        {
            IEnumerable<int> divisores = CreateLista();
            var primos = new Primos();
            primos.AdicionaPrimos(divisores.ToList());

            List<int> pr = new List<int> { 1, 3, 5 };
            Assert.Equal(primos.Primo, pr);
        }

        [Fact]
        public void ErroQuandoAListaForVazia()
        {
            var primos = new Primos();
            var ex = Assert.Throws<BusinessRuleException>(() => primos.AdicionaPrimos(new List<int>()));
            Assert.Equal("Erro a lista não pode ser vazia", ex.Message);
        }

        private IEnumerable<int> CreateLista()
        {
            var lista = new Primos();
            var ls = new List<int> { 1, 3, 5, 9, 15 };
            lista.Divisores = ls;
            return lista.Divisores;
        }
    }
}
