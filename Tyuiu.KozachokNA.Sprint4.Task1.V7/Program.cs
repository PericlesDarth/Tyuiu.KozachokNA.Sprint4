namespace Tyuiu.KozachokNA.Sprint4.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foo = DataService.SumOfEvens(DataService.myInput());
            Console.WriteLine(foo);
        }
    }
}
