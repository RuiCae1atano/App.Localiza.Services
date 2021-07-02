using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Api.NumeroPrimos.Core.ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static bool EhPrimo(this int n)
        {
            if (n <= 0)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
