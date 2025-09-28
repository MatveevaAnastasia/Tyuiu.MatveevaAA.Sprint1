using Tyuiu.MatveevaAA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.MatveevaAA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "231";
            Assert.AreEqual(wait, res);
        }
    }
}
