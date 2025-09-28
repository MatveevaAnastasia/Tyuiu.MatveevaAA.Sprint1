using Tyuiu.MatveevaAA.Sprint1.Task2.V1.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4000;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1,609, res);
        }
    }
}
