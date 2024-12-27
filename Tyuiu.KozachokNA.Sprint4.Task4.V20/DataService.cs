using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task4.V20
{
    internal class DataService
    {
        public static int[,] myInput(int a, int b)
        {
            int[,] array = new int[a, b];
            string str;
            string[] foo;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                str = Console.ReadLine();
                foo = str.Split(", ");
                for (int j = 0; j < foo.Length; j++)
                {
                    array[i, j] = int.Parse(foo[j]);
                }
            }
            return array;
        }

        public static int[,] ModifyArray(int[,] array)
        {
            int[,] foo = array;
            for (int i = 0; i < foo.GetLength(0); i++)
            {
                for (int j = 0; j < foo.GetLength(1); j++)
                {
                    if (foo[i, j] % 2 == 0) { foo[i, j] = 1; }
                }
            }
            return foo;
        }

        public static void myOutput(int[,] array)
        {
            string foo = "";
            for (int i = 0; i < array.Length; i++)
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
