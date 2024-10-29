using Tyuiu.MolchankinaAP.Sprint4.Task5.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Создание случайной матрицы 5x5
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-3, 5); // Диапазон от -3 до 4
                }
            }

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            // Вызов метода Calculate
            int[,] result = ds.Calculate(matrix);

            // Вывод измененной матрицы
            Console.WriteLine("\nИзмененная матрица:");
            PrintMatrix(result);

            Console.ReadKey(); // Ожидание нажатия клавиши для завершения приложения
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
