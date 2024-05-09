using Core.Models;
using Fluxor;

namespace Redux.Weather
{
    public class WeatherState
    {
        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public WeatherState() { }
        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
        }
    }
}
