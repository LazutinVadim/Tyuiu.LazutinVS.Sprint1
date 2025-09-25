using Tyuiu.LazutinVS.Sprint1.Task2.V21.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 2;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
