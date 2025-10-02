using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.LazutinVS.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            {
                throw new ArgumentException("икс равен 0");
            }

            double one = Math.Pow(2, -x);
            double two = (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double three = -Math.Cos(Math.Pow(x, 2));
            double four = Math.Sin(2 * x * y);

            double result = one + two + three + four;
            return Math.Round(result, 3);
        }
    }
}
