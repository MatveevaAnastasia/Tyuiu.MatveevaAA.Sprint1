
using Tyuiu.MatveevaAA.Sprint1.Task0.V7.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExspenssion()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
