using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolchankinaAP.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] array)
        {
            int minElement = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 1] < minElement)
                {
                    minElement = array[i, 1];
                }
            }
            return minElement;
        }
    }
}
