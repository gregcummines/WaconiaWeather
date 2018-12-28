using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace WaconiaWeather.Services
{
    internal class WeatherService
    {
        const string url = "http://api.openweathermap.org/data/2.5/weather?zip=55387,us&units=imperial&APPID=17c80d61218c8133145a0b91275950c9";
        private HttpClient httpClient = new HttpClient();

        public string GetTemperature()
        {
            var temp = string.Empty;
            try
            {
                var uri = new Uri(url);
                var response = httpClient.GetAsync(uri);
                if (response.Result.IsSuccessStatusCode)
                {
                    var content = response.Result.Content.ReadAsStringAsync();
                    var rootObject = JsonConvert.DeserializeObject<RootObject>(content.Result);
                    temp = rootObject.main.temp.ToString() + "F";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return temp;
        }
    }
}
