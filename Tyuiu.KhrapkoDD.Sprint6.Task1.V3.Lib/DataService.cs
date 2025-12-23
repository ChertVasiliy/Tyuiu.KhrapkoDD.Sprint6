using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhrapkoDD.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int index = 0;
            double[] mass = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((double)i * 2d - 0.5 == 0)
                {
                    mass[index] = 0;
                }
                else
                {
                    mass[index] = Math.Round(5d - 3d * (double)i + ((1d + Math.Sin(i)) / (2d * (double)i - 0.5)), 2);
                }
                index++;
            }
            return mass;
        }
    }
}
