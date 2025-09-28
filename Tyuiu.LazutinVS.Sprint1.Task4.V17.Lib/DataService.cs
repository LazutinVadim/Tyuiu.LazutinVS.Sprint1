using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LazutinVS.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            double den = x - 5 * y;
            if (den < 0 || den == 0)
            {
                return 0;
            }
            else
            { 
                return Math.Round(1/Math.Sqrt(den),3);
            }

        }
    }
}
