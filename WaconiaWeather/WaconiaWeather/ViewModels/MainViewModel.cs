using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaconiaWeather.Services;
using Xamarin.Forms;

namespace WaconiaWeather.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        private WeatherService weatherService = new WeatherService();

        public MainViewModel()
        {
            UpdateTemperature();
            Device.StartTimer(TimeSpan.FromSeconds(60), () =>
            {
                UpdateTemperature();

                return true; // True = Repeat again, False = Stop the timer
            });
        }

        private string currentTemperature = "Unknown";
        public string CurrentTemperature
        {
            get { return currentTemperature; }
            set { SetProperty(ref currentTemperature, value); }
        }

        private DateTime lastUpdated = DateTime.Now;
        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { SetProperty(ref lastUpdated, value); }
        }

        private bool isFetchingWeather;
        public bool IsFetchingWeather
        {
            get { return isFetchingWeather; }
            set { SetProperty(ref isFetchingWeather, value); }
        }

        private void UpdateTemperature()
        {
            Task.Run(() => {
                try
                {
                    IsFetchingWeather = true;
                    CurrentTemperature = weatherService.GetTemperature();
                    LastUpdated = DateTime.Now;
                }
                finally
                {
                    IsFetchingWeather = false;
                }
            });
        }

        public Command RefreshCommand
        {
            get
            {
                return new Command(Refresh);
            }
        }

        private void Refresh()
        {
            UpdateTemperature();
        }
    }
}
