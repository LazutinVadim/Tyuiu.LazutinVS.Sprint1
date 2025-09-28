using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LazutinVS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            return ((int)(number * 1000) % 1000) / 100 == 0 || ((int)(number * 1000) % 100) / 10 == 0 || (int)(number * 1000) % 10 == 0;
        }
    }
}
