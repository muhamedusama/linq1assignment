using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1demo
{
    internal static class intExtensions
    {
        public static int reverse (this int number)
        {
            int reversednumber = 0, remainder;
            while(number!=0)
            {
                remainder= number % 10;
                reversednumber = reversednumber * 10 + remainder;
                number=number / 10;
            }
            return reversednumber;
        }
    }
}
