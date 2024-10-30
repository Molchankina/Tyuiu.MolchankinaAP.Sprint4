using Tyuiu.MolchankinaAP.Sprint4.Task6.V22.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] test = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Количество элементов длинна которых = 4:");
            string[] arr = ds.Calculate(test) as string[];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
