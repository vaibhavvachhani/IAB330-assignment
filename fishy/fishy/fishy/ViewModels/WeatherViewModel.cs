using fishy.Models;
using fishy.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fishy.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        private WeatherInfo currentWeather;

        public WeatherInfo CurrentWeather {
            get
            {
                return currentWeather;
            }
            set {
                currentWeather = value;
                OnPropertyChanged();
            }
        }
        

        public WeatherViewModel()
        {

        }

        public async Task GetLocation()
        {
            var latitude = await LocationService.GetLatitude();
            var longitude = await LocationService.GetLongitude();
            await GetCurrentWeather(latitude, longitude);
        }


        public async Task GetCurrentWeather(double latitude, double longitude)
        {
            CurrentWeather = await WeatherService.GetWeatherInfo(latitude, longitude);
        }

    }
}
