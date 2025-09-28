using Tyuiu.MatveevaAA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 1, h = 2;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(6.283, res);
        }
    }
}
