using Tyuiu.LazutinVS.Sprint1.Task6.V14.Lib;
namespace Tyuiu.LazutinVS.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string input = "привет";
            bool res = ds.CheckLowerCaseRusLetters(input);
            Assert.IsTrue(res, "Строка из строчных русских букв должна возвращать true");
        }
    }
}
