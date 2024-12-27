namespace Tyuiu.KozachokNA.Sprint4.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] foo = ds.GenerateArray(-9, 4, 5, 5);
            int bar = DataService.SearchForNegatives(foo);
            Console.WriteLine(bar);
        }
    }
}
