using Tyuiu.BuyanovaVI.Sprint6.Task0.V9.Lib;


namespace Tyuiu.BuyanovaVI.Sprint6.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(-2.556, service1.Calculate(3));
        }
    }
}