using Tyuiu.TalalaevaAV.Sprint6.Task1.V14.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] valueArray=ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -2.15, -2.57,-3,-3.83,-11.7,3,2.19,3.31,2.97,1.18,0.03 };
            CollectionAssert.AreEqual(valueArray, wait);
        }
    }
}