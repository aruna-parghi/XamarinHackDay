using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormsSampleWeather
{
    public class App : Application
    {
        public App()
        {
            var selectCity = new SelectCityPage();
            var nav = new NavigationPage(selectCity);
            selectCity.BindingContext = new SelectCityViewModel()
            {
                NavPage = nav
            };
            MainPage = nav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
