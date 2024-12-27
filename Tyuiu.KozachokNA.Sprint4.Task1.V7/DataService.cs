using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task1.V7
{
    internal class DataService
    {
        public static int[] myInput()
        {
            string input = Console.ReadLine();
            string[] foo = input.Split(", ");
            int[] result = new int[foo.Length];
            for (int i = 0; i < foo.Length; i++)
            {
                result[i] = int.Parse(foo[i]);
            }
            return result;
        }

        public static int SumOfEvens(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
