namespace Tyuiu.KozachokNA.Sprint4.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = DataService.myInput(5, 5);
            data =  DataService.ModifyArray(data);
            DataService.myOutput(data);
        }
    }
}
