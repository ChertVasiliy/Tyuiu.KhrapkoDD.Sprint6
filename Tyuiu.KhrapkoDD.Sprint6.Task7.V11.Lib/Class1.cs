using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Lib
    {
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            string[] mass = File.ReadAllLines(path);
            int s = 10;
            for (int i = 0; i < s; i++)
            {
                mass[i] = mass[i].Replace(";", " ");
            }

            int[,] matrix = new int[s, s];
            for (int i = 0; i < s; i++)
            {
                int[] row = mass[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < s; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[,] res = new int[s, s];
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int xRows = 4;

            for (int r = xRows; r <= xRows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] < 0)
                    {
                        matrix[r, c] = 9;
                    }
                }
            }
            return matrix;
        }
    }
}
