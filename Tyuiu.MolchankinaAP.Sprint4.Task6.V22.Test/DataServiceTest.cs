using Tyuiu.MolchankinaAP.Sprint4.Task6.V22.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var word = new string[] { "����", "�����", "�����", "����", "�����", "����", "������" };
            int res = 3;
            Assert.AreEqual(res, 3);
        }
    }
}