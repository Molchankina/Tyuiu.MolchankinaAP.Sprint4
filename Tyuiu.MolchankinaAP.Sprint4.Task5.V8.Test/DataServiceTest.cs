using Tyuiu.MolchankinaAP.Sprint4.Task5.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            // �������� ��������� ������� 5x5
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-3, 5); // �������� �� -3 �� 4
                }
            }

            // ����� �������� �������
            Console.WriteLine("�������� �������:");
            PrintMatrix(matrix);

            // ����� ������ Calculate
            int[,] result = ds.Calculate(matrix);

            // ����� ���������� �������
            Console.WriteLine("\n���������� �������:");
            PrintMatrix(result);
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