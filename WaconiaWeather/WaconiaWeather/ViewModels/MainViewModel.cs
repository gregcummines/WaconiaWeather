using System;
using System.Collections.Generic;
using System.Text;
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
            Device.StartTimer(TimeSpan.FromSeconds(30), () =>
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

        private void UpdateTemperature()
        {
            CurrentTemperature = weatherService.GetTemperature();
            LastUpdated = DateTime.Now;
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
