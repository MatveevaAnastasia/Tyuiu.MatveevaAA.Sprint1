using Tyuiu.MatveevaAA.Sprint1.Task4.V2.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpersiion()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double wait = 0.2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
