using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint4.Task6.V18
{
    internal class DataService
    {
        public static void PrintLongElements(string[] array)
        {
            string[] foo = Array.FindAll(array, s => s.Length > 6);
            foreach (string s in foo)
            {
                Console.WriteLine(s);
            }
        }
    }
}
