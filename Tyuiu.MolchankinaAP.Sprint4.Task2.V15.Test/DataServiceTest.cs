using Tyuiu.MolchankinaAP.Sprint4.Task2.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[0];
            int expectedSum = 0;
            int actualSum = ds.Calculate(array);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}