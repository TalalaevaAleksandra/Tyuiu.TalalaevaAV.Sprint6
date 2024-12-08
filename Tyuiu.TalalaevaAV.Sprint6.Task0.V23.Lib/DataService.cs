using tyuiu.cources.programming.interfaces.Sprint6; 
namespace Tyuiu.TalalaevaAV.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double c = (x+1)/(x+2.0);
            double y = Math.Log(c);
            return Math.Round(y,3);
        }
    }
}
