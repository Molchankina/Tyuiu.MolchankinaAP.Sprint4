using Tyuiu.MolchankinaAP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "264795863157";
            int n = 3;
            int m = 4;
            try
            {
                int sum = ds.Calculate(n, m, value);
                Console.WriteLine("Сумма нечетных чисел: {0}", sum);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
