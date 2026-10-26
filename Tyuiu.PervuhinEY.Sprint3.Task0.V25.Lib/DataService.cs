using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PervuhinEY.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            int x = 5;
            for (int i = startValue; i <= stopValue; i++)
            {
                double xPow = Math.Pow(x, i);
                double fraction = 4.0 / (1.0 + xPow);
                sumSeries = sumSeries + Math.Pow(fraction, i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
