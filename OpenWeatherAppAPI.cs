using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;

namespace APIsAndJSONex
{
    public class OpenWeatherAppAPI
    {
        public static void GetWeather()
        {
            var client = new HttpClient();
            Console.WriteLine("Please enter your OpenWeatherAPP API Key");
            var API_key = Console.ReadLine();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter city name: ");
                var city_name = Console.ReadLine();
                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&units=imperial&appid={API_key}";
                Console.WriteLine();

                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine(formattedResponse);
                Console.WriteLine();
                Console.WriteLine("Do you want to enter another city?");
                var userInput = Console.ReadLine();
                if(userInput.ToLower() == "no")
                {
                    flag = false;
                }
            }
        }
    }
}
