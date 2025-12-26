using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapkoDD.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] massive = new double[len];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = (2.0 * x + 6.0) / (Math.Cos(x) + x) - 3.0;
                y = Math.Round(y, 2);
                if (double.IsNaN(y) && double.IsInfinity(y))
                {
                    y = 0;
                }

                massive[i] = y;
                i++;
            }
            return (massive);
        }
    }
}
