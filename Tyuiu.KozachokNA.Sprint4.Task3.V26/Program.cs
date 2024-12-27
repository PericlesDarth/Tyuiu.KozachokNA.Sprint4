namespace Tyuiu.KozachokNA.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] foo = new int[5, 5];
            foo = DataService.ArrayHolder();
            int bar = DataService.MaxInRow(foo, 1);
            Console.WriteLine(bar);
        }
    }
}
