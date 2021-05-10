using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CelciusKelvin
{
    internal interface IWeatherAccess
    {
        Task<IEnumerable<Tuple<DateTime, double>>> HourlyTemperatureAsync();
    }
}