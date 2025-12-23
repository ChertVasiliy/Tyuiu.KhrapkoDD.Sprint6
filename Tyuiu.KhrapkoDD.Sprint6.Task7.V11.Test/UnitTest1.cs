using System.Data;
using Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = "C:\\InPutDataFileTask7V11.csv";
            int[,] wait = { {1,4,18,17,2,13,14,-14,1,-18},
                            {-15, 18, 7, -3, -3, -6, -1, -17, 18, -18},
                            { 10, -15, 2, -2, -8, -16, 1, 3, -2, -13 },
                            { -4, -7, 13, -7, -11, 11, 7, -20, -10, -16 },
                            {14, 9, 9, 20, 5, 0, 5, 1, 9, 9 },
                            { 10, 12, -1, 8, 2, 3, 15, -17, 4, -4 },
                            { 8, -19, 0, 20, 1, -9, 10, 7, 2, 1 },
                            { -14, -15, 6, 1, -11, -9, 11, 13, 0, 13 },
                            { -14, 16, -6, 5, 11, -1, -11, -6, 5, -7 },
                            {-17, 17, -8, -20, 5, 12, 20, 13, -7, 15 } };
            int[,] result = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}