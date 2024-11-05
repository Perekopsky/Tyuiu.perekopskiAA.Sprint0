using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PerekopskyAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PerekopskyAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артур";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Артур", res);
        }
    }
}
