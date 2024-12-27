using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task5.V17
{
    internal class DataService
    {
        Random rng;
        public DataService()
        {
            this.rng = new Random();
        }
        public int[,] GenerateArray(int a, int b, int rows, int cells)
        {
            int[,] res = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    res[i, j] = this.rng.Next(a, b);
                }
            }
            return res;
        }

        public static int SearchForNegatives(int[,] array)
        {
            int res = 0;
            for (int i = 0; i <= array.GetLength(0); i++)
            {
                for (int j; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
