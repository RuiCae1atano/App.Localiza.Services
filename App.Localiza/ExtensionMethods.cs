using System;
using System.Collections.Generic;
using System.Text;

namespace App.Localiza
{
    public static class ExtensionMethods
    {
        public static bool EhPrimo(this int n)
        {
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
