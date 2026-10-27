using Tyuiu.PervuhinEY.Sprint3.Task4.V23.Lib;
namespace Tyuiu.PervuhinEY.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();


            int startValue = -5;
            int stopValue  =  5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 244.656;

            Assert.AreEqual(res, wait);

        }
    }
}
