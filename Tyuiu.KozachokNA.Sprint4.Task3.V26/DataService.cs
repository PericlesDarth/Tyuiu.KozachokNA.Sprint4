using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task3.V26
{
    internal class DataService
    {
        public static int[,] ArrayHolder()
        {
            int[,] res = new int[5, 5];
            int[] foo = [4, 3, 2, 6, 2];
            for (int i = 0; i < foo.Length; i++)
            {
                res[0, i] = foo[i];
            }
            foo = [5, 2, 2, 5, 6];
            for (int i = 0; i < foo.Length; i++)
            {
                res[1, i] = foo[i];
            }
            foo = [2, 5, 4, 5, 6];
            for (int i = 0; i < foo.Length; i++)
            {
                res[2, i] = foo[i];
            }
            foo = [4, 5, 2, 4, 6];
            for (int i = 0; i < foo.Length; i++)
            {
                res[3, i] = foo[i];
            }
            foo = [6, 5, 4, 3, 6];
            for (int i = 0; i < foo.Length; i++)
            {
                res[4, i] = foo[i];
            }
            return res;
        }

        public static int MaxInRow(int[,] array, int row)
        {
            int res = int.MinValue;
            int foo = array.GetLength(1);
            for (int i = 0; i < foo; i++)
            {
                if (res < array[row, i])
                {
                    res = array[row, i];
                }
            }
            return res;
        }
    }
}
