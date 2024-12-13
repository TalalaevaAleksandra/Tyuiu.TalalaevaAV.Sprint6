using Tyuiu.TalalaevaAV.Sprint6.Task6.V17.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            DataService ds = new DataService();

            string res = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";
            Assert.AreEqual(wait, res);
        }
    }
}