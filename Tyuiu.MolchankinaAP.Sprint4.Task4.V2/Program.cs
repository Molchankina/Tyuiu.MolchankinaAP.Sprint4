using Tyuiu.MolchankinaAP.Sprint4.Task4.V2.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите 25 целых чисел в диапазоне от 2 до 9, разделенных пробелами: ");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            if (inputNumbers.Length != 25)
            {
                Console.WriteLine("Неверный формат ввода.");
                return;
            }

            int[,] array = new int[5, 5];
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!int.TryParse(inputNumbers[count].Trim(), out array[i, j]) || array[i, j] < 2 || array[i, j] > 9)
                    {
                        Console.WriteLine("Неверный формат ввода.");
                        return;
                    }
                    count++;
                }
            }


            int[,] res = ds.Calculate(array);

            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{res[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
