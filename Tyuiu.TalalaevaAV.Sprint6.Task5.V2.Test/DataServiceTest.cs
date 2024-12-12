using Tyuiu.TalalaevaAV.Sprint6.Task5.V2.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = [-1,-2,-3,-5,-6,-7,-8,-9,-10];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}