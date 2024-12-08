using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Interfaces;
using Tyuiu.TalalaevaAV.Sprint6.Task0.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int x = 3;
            double y = ds.Calculate(x);
            Assert.AreEqual(-0.223, y);
        }
    }
}