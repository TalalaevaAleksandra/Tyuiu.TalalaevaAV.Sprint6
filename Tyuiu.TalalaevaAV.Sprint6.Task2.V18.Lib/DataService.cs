using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TalalaevaAV.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                y = (3 * Math.Cos(i)) / (4 * i - 0.5) + Math.Sin(i) - 5 *i -2;
                y=Math.Round(y,2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}
