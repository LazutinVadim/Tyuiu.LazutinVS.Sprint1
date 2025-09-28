using Tyuiu.LazutinVS.Sprint1.Task5.V6.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(8);
            Assert.AreEqual(1, res);
        }
    }
}
