using Tyuiu.PervuhinEY.Sprint3.Task6.V12.Lib;
namespace Tyuiu.PervuhinEY.Sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 221;
            Assert.AreEqual(res, wait);
            
        }
    }
}
