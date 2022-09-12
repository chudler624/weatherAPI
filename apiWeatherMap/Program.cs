
using Newtonsoft.Json.Linq;

var client = new HttpClient();


Console.WriteLine("Enter city name");
var cityName = Console.ReadLine();
var apiKey = "77ddc5807aff734585b8bee62e50275b";
var openWeatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

var weatherReport = client.GetStringAsync(openWeatherURL).Result;
var cityTemp = JObject.Parse(weatherReport)["main"]["temp"].ToString();
Console.WriteLine("Today's temperature is");
Console.WriteLine(cityTemp);
Console.WriteLine();

