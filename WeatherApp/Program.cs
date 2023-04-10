using Newtonsoft.Json.Linq;

namespace WeatherApp;
class Program
{
    static void Main(string[] args)
    {
        string Key = File.ReadAllText("appsettings.json");

        string APIKey = JObject.Parse(Key).GetValue("DefaultKey").ToString();

        Console.WriteLine("Please enter your zipcode");

        var zipCode = Console.ReadLine();

        var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

        Console.WriteLine();

        Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");

    }
}

