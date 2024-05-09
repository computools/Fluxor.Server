using API.Data;
using Fluxor;

namespace Redux.Weather
{
    public class Effects
    {
        private readonly WeatherForecastService _weatherForecastService;

        public Effects(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [EffectMethod]
        public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);

            dispatcher.Dispatch(new FetchDataResultAction(forecasts: forecasts!));
        }
    }
}
