using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.TalalaevaAV.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    string[] words = line.Split(' ');
                    if (words.Length >= 3)
                    {
                        resStr += words[2] + ' ';
                    }
                }
            }
            resStr = resStr.Trim();
            return resStr;
        }
    }
}
