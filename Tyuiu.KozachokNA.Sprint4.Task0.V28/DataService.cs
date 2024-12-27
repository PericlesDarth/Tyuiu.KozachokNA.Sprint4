using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task0.V28
{
    internal class DataService
    {
        public static int ProductOfEvens(int[] array)
        {
            int p = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    p *= i;
                }
            }
            return p;
        }
    }
}
