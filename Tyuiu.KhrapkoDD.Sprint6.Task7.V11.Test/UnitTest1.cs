using Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Lib;
using System.IO;


namespace Tyuiu.KhrapkoDD.Sprint6.Task7.V11
{
    public class DataServiceTests
    {
        private DataService _dataService = new DataService();

        public void RunTests()
        {
            TestMain();
            TestEmptyFile();
            TestInvalidFile();
        }

        private void TestMain()
        {
            string tempFile = "temp.csv";
            File.WriteAllText(tempFile, @"1;4;18;17;2;13;14;-14;1;-18
-15;18;7;-3;-3;-6;-1;-17;18;-18
10;-15;2;-2;-8;-16;1;3;-2;-13
-4;-7;13;-7;-11;11;7;-20;-10;-16
14;-8;-2;20;5;0;5;1;-6;-17
10;12;-1;8;2;3;15;-17;4;-4");

            int[,] matrix = _dataService.GetMatrix(tempFile);

            // Проверка размера матрицы
            if (matrix.GetLength(0) != 6 || matrix.GetLength(1) != 10)
                throw new Exception("Ошибка размера матрицы");

            // Проверка 5 строки (индекс 4)
            if (matrix[4, 1] != 9 || matrix[4, 2] != 9 || matrix[4, 8] != 9 || matrix[4, 9] != 9)
                throw new Exception("Ошибка замены отрицательных чисел");

            // Проверка остальных значений
            if (matrix[4, 0] != 14 || matrix[4, 3] != 20 || matrix[4, 4] != 5)
                throw new Exception("Ошибка сохранения положительных чисел");

            File.Delete(tempFile);
        }

        private void TestEmptyFile()
        {
            string emptyFile = "empty.csv";
            File.WriteAllText(emptyFile, "");

            try
            {
                _dataService.GetMatrix(emptyFile);
                throw new Exception("Должен был сгенерировать исключение");
            }
            catch { }
            finally
            {
                File.Delete(emptyFile);
            }
        }

        private void TestInvalidFile()
        {
            string invalidFile = "invalid.csv";
            File.WriteAllText(invalidFile, "1;2;3\n4;5");

            try
            {
                _dataService.GetMatrix(invalidFile);
                throw new Exception("Должен был сгенерировать исключение");
            }
            catch { }
            finally
            {
                File.Delete(invalidFile);
            }
        }
    }
}