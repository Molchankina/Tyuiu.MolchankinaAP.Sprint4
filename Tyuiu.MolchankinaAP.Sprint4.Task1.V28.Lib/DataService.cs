using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MolchankinaAP.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    product *= element;
                }
            }
            return product;
        }
    }
}
