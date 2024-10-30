using Tyuiu.MolchankinaAP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "264795863157";
            int n = 3;
            int m = 4;
            int expectedSum = 37;

            int actualSum = ds.Calculate(n, m, value);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}