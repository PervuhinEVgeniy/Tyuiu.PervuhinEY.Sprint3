using Newtonsoft.Json.Linq;
using Tyuiu.PervuhinEY.Sprint3.Task3.V12.Lib;
namespace Tyuiu.PervuhinEY.Sprint3.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "bkkrk ckkkcs ksr";
            char item = 'k';
            int res = ds.GetMaxCharCount(value, item);
            int wait = 3;
            Assert.AreEqual(res, wait);

        }
    }
}
