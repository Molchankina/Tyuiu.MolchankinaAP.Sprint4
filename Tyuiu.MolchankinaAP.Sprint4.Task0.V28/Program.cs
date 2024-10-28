using Tyuiu.MolchankinaAP.Sprint4.Task0.V28.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.GetMultEvenArrEl(array);
            Console.WriteLine("Произведение = " + result);
            Console.ReadKey();
        }
    }
}
