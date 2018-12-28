using System;
using System.Collections.Generic;
using System.Text;

namespace WaconiaWeather.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        private string currentTemperature = "Unknown";
        public string CurrentTemperature
        {
            get { return currentTemperature; }
            set { SetProperty(ref currentTemperature, value);  }
        }
    }
}
