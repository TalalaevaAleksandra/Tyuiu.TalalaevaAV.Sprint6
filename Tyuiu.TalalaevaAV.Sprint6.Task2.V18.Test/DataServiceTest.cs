using Tyuiu.TalalaevaAV.Sprint6.Task2.V18.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {23.92, 18.88,13.1, 7.24, 1.8,-8,-5.7, -11.26,-17.12, -22.88,-27.92};
            CollectionAssert.AreEqual(valueArray, wait);
        }
    }
}