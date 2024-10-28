using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolchankinaAP.Sprint4.Task2.V15.Lib
{
    public class DataService : ISprint4Task2V15
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                }
            }
            return sum;
        }
    }
}
