using System;
using Xunit;
using Localiza.Api.NumerosDivisores.Models;
using Localiza.Api.NumerosDivisores.Core;

namespace Localiza.Api.NumerosDivisores.Tests
{
    public class NumerosDivisoresServiceTests
    {
        [Fact]
        public void GetListaNumerosDivisoresFuncionandoCom45()
        {
            var divisores = new Divisores();
            divisores.AdicionaDivisores(45);
            Assert.True(divisores.Divisor.Count > 0);
        }


        [Fact]
        public void ErroAoTestarNumero0() 
        {
            var divisores = new Divisores();
            var ex = Assert.Throws<BusinessRuleException>(() => divisores.AdicionaDivisores(0));
            Assert.Equal("Erro ao adicionar numero {num}", ex.Message);
        }
    }
}
