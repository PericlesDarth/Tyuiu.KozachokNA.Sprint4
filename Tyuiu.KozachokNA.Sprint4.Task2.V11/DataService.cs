using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task2.V11
{
    internal class DataService
    {
        Random rng;
        public DataService()
        {
            this.rng = new Random();
        }
        public int[] GenerateArray(int count, int a, int b)
        {
            int[] res = new int[count];
            for (int i = 0; i < count; i++)
            {
                res[i] = this.rng.Next(a, b);
            }
            return res;
        }

        public int SumOfEvens(int[] array)
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

        public static void myOutput(int[] array)
        {
            string foo = "";
            for (int i = 0;i < array.Length;i++)
            {
                if (i < array.Length - 1)
                {
                    foo += Convert.ToString(array[i]) + ", ";
                }
                else
                {
                    foo += Convert.ToString(array[i]);
                }
            }
            Console.WriteLine(foo);
        }
    }
}
