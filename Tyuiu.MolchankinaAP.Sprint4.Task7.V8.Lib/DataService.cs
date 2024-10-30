using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolchankinaAP.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {
            if (n * m != value.Length)
            {
                throw new ArgumentException("Размер матрицы не соответствует длине строки.");
            }

            int sum = 0;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int number = int.Parse(value[index].ToString());
                    if (number % 2 != 0)
                    {
                        sum += number;
                    }
                    index++;
                }
            }
            return sum;
        }
    }
}
