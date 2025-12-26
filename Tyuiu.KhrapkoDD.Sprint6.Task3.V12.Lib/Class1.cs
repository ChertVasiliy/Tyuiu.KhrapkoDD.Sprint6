using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhrapkoDD.Sprint6.Task3.V12.Lib
{
    public class DataService : ISprint6Task3V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (y <= 0 && matrix[y, x] % 2 == 0)
                    {
                        matrix[y, x] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
