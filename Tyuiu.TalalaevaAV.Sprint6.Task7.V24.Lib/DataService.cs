using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TalalaevaAV.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            string filedata = File.ReadAllText(path);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            int xrow = 1;

            int[,] resMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arrayValues[i, j] %2==0 && i == xrow)
                    {
                        resMatrix[i, j] = 1;
                    }
                    else
                    {
                        resMatrix[i, j] = arrayValues[i, j];
                    }
                }
            }

            return resMatrix;
        }
    }
}
