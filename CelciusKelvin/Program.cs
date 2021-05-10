/*
 / Questions  - C#
// 1) Implement interface to return hourly temperature forecast (random temperatures)
// for next 48 hours.
// Range 9 - 12 deg C. Return temperatures in K (C + 273).
// 2) Write a unit test for 1)
 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
 
namespace WeatherLib
{
public interface IWeatherAccess
{
Task<IEnumerable<Tuple<DateTime, double>>> HourlyTemperature();
}
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusKelvin
{
    class Program
    {
        static void Main(string[] args)
        {

            var compute = CalculateTemperatue(9.0);
            

        }
        public static List<Tuple<DateTime, double>> CalculateTemperatue(double temp)
        {
            int hourscount = 48;

            var weathertuple = new List<Tuple<DateTime, double>>();
    

            for(int i = 0; i < hourscount; i++)
            {
                weathertuple.Add(new Tuple<DateTime, double>(DateTime.Today.AddHours(i+1), temp +273));
            }


            return weathertuple;
        }
    }
}
