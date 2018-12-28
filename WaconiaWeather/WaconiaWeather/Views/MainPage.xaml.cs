using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaconiaWeather.ViewModels;
using Xamarin.Forms;

namespace WaconiaWeather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        //private HttpClient httpClient = new HttpClient();
        //private string url = "http://api.openweathermap.org/data/2.5/weather?zip=55387,us&units=imperial&APPID=17c80d61218c8133145a0b91275950c9";
        //private string _currentTemperature = "Loading Waconia temp...";
        //private DateTime _lastUpdated = DateTime.Now;

        //public string CurrentTemperature
        //{
        //    get
        //    {
        //        return _currentTemperature;
        //    }
        //    set
        //    {
        //        _currentTemperature = value;
        //        OnPropertyChanged(nameof(CurrentTemperature));
        //    }
        //}

        //public DateTime LastUpdated
        //{
        //    get
        //    {
        //        return _lastUpdated;
        //    }

        //    set
        //    {
        //        _lastUpdated = value;
        //        OnPropertyChanged(nameof(LastUpdated));
        //    }
        //}

        //public MainPage()
        //{
        //    // http://api.openweathermap.org/data/2.5/weather?zip=55387,us&units=imperial&APPID=17c80d61218c8133145a0b91275950c9
        //    InitializeComponent();

        //    BindingContext = this; // Applicable to all the child controls   

        //    UpdateTemperature();

        //    Device.StartTimer(TimeSpan.FromSeconds(30), () =>
        //    {
        //        UpdateTemperature();

        //        return true; // True = Repeat again, False = Stop the timer
        //    });
        //}

        //private void UpdateTemperature()
        //{
        //    try
        //    {
        //        var uri = new Uri(url);
        //        var response = httpClient.GetAsync(uri);
        //        if (response.Result.IsSuccessStatusCode)
        //        {
        //            var content = response.Result.Content.ReadAsStringAsync();
        //            var rootObject = JsonConvert.DeserializeObject<RootObject>(content.Result);
        //            this.CurrentTemperature = rootObject.main.temp.ToString() + "F";
        //            this.LastUpdated = DateTime.Now;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"				ERROR {0}", ex.Message);
        //    }
        //}

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    UpdateTemperature();
        //}
    }
}
