using Tyuiu.LazutinVS.Sprint1.Task3.V17.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            var res = ds.ZeroCheck(a);
            Assert.AreEqual(true, res);
        }
    }
}
