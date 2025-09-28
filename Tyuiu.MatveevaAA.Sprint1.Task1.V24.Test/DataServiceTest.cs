using Tyuiu.MatveevaAA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExspenssion()
        {
            DataService ds = new DataService();
            double x = 0.5, y = -1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}
