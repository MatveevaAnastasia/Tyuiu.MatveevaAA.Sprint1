using Tyuiu.MatveevaAA.Sprint1.Task7.V10.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            double x = 1.0;

            DataService ds = new DataService();

            double res = ds.Calculate(x);

            double expected = 2 * (1 / Math.Tan(3 * x)) - Math.Log(Math.Cos(x)) / Math.Log(1 + Math.Pow(x, 2));

            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
