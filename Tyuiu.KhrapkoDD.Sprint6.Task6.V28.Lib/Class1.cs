using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapkoDD.Sprint6.Task6.V28.Lib
{

    public class DataService : ISprint6Task6V28
    {
        public string CollectTextFromFile(string path)
        {
            var ret = String.Empty;

            using (StreamReader sr = new(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != String.Empty)
                        ret += $" {line.Split(' ')[^2]}";
                }
            }
            return ret[1..];
        }
    }
}