using Tyuiu.LazutinVS.Sprint1.Task4.V17.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            double a = 25.0;
            double b = 0;
            var res = ds.Calculate(a,b);
            Assert.AreEqual(0.200, res);
        }
    }
}