using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhrapkoDD.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow(x, 3)) / (Math.Pow(x, 2) - 1);
            return Math.Round(res, 3);
        }
    }
}
