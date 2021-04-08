using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Weather.Models;
using System.Net.Http.Headers;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WeatherType weather = new WeatherType();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Weather(CityName nameOfCity)
        {
           
            //Creating HttpClient to get data from API
            var client = new HttpClient();
            //BaseURL for API with endpoint added later
            client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");

            //Current weather url
            string urlForCurrentWeather = $"weather?q={nameOfCity.Name}&appid=53868bf10a1404c9be6d4527cab7346e&units=metric";
            //defining header payload information
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicaiton/json"));
            //requesting and storing response information
            HttpResponseMessage response = client.GetAsync(urlForCurrentWeather).Result;

            //Check done to see if response was a success
            if (response.IsSuccessStatusCode)
            {
                //getting data from the JSON token received from the API call
                var weatherDataObject = response.Content.ReadAsStringAsync();
                //Parsing the data to JSON format
                var parsedObject = JObject.Parse(weatherDataObject.Result.ToString());

                //gathering required data from the JSON object, code comment describes the code below it
                //temperature value obtianed from array
                var temperature = parsedObject["main"]["temp"];

                //weather details are stored in a multidimensional array, main array here is weatherDetails with further details obtainable such as description etc
                var weatherDetails = parsedObject["weather"][0];
                var weatherDescription = weatherDetails["description"];
                var weatherClimate = weatherDetails["main"];

                //adding data to the WeatherType model
                weather.CityName = parsedObject["name"].ToString();
                weather.Temperature = Math.Round((double)temperature, 1);
                weather.WeatherClimate = weatherDescription.ToString();
                weather.PhotoURL = $"https://source.unsplash.com/featured/1600x900/?{weather.WeatherClimate}";
                weather.Climate = weatherClimate.ToString();

             

            }
            else
            {
                weather.ErrorMessage = response.ReasonPhrase;

                return View("Error");
            }
            client.Dispose();

            return View(weather);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
