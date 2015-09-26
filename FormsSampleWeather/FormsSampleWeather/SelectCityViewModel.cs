using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FormsSampleWeather
{
    public class SelectCityViewModel
    {
        public NavigationPage NavPage { get; set; }

        public Command SelectCity
        {
            get
            {
                return new Command<string>(async (city) =>
                {
                    var weather = await DownloadWeather(city);
                    var page = new ViewWeatherPage();
                    weather.FirstOrDefault().CityImage = city + ".jpg";
                    page.BindingContext = weather.FirstOrDefault();
                    await NavPage.PushAsync(page);
                });
            }
        }


        private async Task<List<Weather>> DownloadWeather(string city)
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetAsync("http://xamarinhackdayweather.azurewebsites.net:80/api/City/" + city);

                var result = JsonConvert.DeserializeObject<List<Weather>>(await data.Content.ReadAsStringAsync());

                return result;
            }
        }
    }
}
