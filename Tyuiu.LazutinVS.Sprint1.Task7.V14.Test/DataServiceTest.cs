using Tyuiu.LazutinVS.Sprint1.Task7.V14.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;

            double result = ds.Calculate(x, y);

            Assert.AreEqual(2.536, result);
        }
    }
}
