using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculating
{
    public static class Factorial
    {
        /// <summary>
        /// Метод вычисления факториала
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Fact(int a)
        {
            int b = 1;
            for (int i = 2; i <= a; i++)
            {
                
                b*= i;
            }

            return b;
        }
    }
}
