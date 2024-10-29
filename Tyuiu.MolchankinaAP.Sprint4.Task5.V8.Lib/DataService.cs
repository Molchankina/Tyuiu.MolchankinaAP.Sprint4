using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolchankinaAP.Sprint4.Task5.V8.Lib
{
    public class DataService : ISprint4Task5V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
            {
                throw new ArgumentException("Матрица должна иметь размер 5x5.");
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
