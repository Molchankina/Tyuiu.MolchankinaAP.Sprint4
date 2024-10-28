using Tyuiu.MolchankinaAP.Sprint4.Task0.V28.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int wait = 9216;

            var rez = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, rez);
        }
    }
}