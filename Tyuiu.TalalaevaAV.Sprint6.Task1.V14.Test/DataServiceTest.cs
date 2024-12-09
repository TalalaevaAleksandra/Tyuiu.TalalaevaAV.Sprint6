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
            double[] wait = { -2.152, -2.57,-3,-3.828,-11.701,3,2.194,3.314,2.97,1.184,0.028 };
            CollectionAssert.AreEqual(valueArray, wait);
        }
    }
}