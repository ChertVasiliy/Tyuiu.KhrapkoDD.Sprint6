using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapkoDD.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Преобразуем строки в числа, фильтруем их и округляем
            double[] numsArray = lines
                .Select(line => Convert.ToDouble(line))
                .Select(val => Math.Round(val, 3)) // Округляем до 3 знаков после запятой
                .Where(val => val < 10) // Оставляем только числа меньше 10
                .ToArray();

            // Выводим результат
            foreach (var num in numsArray)
            {
                Console.WriteLine(num);
            }

            return numsArray;
        }
    }
}