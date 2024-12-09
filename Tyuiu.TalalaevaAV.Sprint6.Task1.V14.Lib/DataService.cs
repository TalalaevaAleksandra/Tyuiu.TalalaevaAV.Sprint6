using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TalalaevaAV.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count=0;
            for (int i = startValue; i <= stopValue; i++) 
            
            {
                if ((Math.Cos(i) + i) != 0)
                {
                     y = Math.Round(((2 * i + 6) / (Math.Cos(i) + i) - 3),2);
                }
                else 
                {
                     y = 0.00;
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
