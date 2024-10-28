using Tyuiu.MolchankinaAP.Sprint4.Task2.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Random random = new Random();
            int[] array = new int[11];

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(2, 8); // Случайные числа от 2 до 7
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов массива:" + result);
            Console.ReadKey();
        }
    }
}
