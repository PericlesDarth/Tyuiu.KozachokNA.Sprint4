namespace Tyuiu.KozachokNA.Sprint4.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int[] foo = dataService.GenerateArray(15, 3, 8);

            DataService.myOutput(foo);
            Console.WriteLine(dataService.SumOfEvens(foo));
        }
    }
}
