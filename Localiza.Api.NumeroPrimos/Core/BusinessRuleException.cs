using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumerosDivisores.Core
{
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message)
        {

        }
    }
}
