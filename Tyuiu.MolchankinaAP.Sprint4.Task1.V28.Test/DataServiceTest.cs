using Tyuiu.MolchankinaAP.Sprint4.Task1.V28.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[0];
            int expectedProduct = 1;
            int actualProduct = ds.Calculate(array);

            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}