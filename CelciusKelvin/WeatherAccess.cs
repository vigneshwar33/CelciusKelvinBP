using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusKelvin
{
    class WeatherAccess : IWeatherAccess
    {
        public async Task<IEnumerable<Tuple<DateTime, double>>> HourlyTemperatureAsync()
        {
            IEnumerable<Tuple<DateTime, double>> x = await HourlyTemperatureAsync();

            throw new NotImplementedException();
        }
    }
}
