using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task7.V6
{
    internal class DataService
    {
        public static int SumOfOdds(string str, int a, int b)
        {
            int[,] tmp = new int[a, b];
            int res = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tmp[i, j] = Convert.ToInt32(str[a * i + j]);
                    if (tmp[i, j] % 2 == 1 )
                    {
                        res += tmp[i, j];
                    }
                }
            }
            return res;
        }
    }
}
