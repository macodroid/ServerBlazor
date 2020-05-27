using System.Collections;
using System.Collections.Generic;

namespace WeatherWorkerService.Models
{
    public class TranslationWeather
    {
        
        public Dictionary<string, string> mainWeather = new Dictionary<string, string>
        {
            {"Thunderstorm","Búrka"},
            {"Drizzle","Mrholenie"},
            {"Rain","Dážď"},
            {"Snow","Sneh"},
            {"Mist","Hmla"},
            {"Smoke","Dym"},
            {"Haze","Opar"},
            {"Dust","Prach"},
            {"Fog","Hmla"},
            {"Ash","Popol"},
            {"Sand","Pisok"},
            {"Squall","Prehánka"},
            {"Tornado","Tornádo"},
            {"Clear","Jasno"},
            {"Clouds","Mraky"},
        };

        public Dictionary<string, string> descriptionWeather = new Dictionary<string, string>
        {
            {"thunderstorm with light rain ", "Búrka so slabým dažďom"},
            {"thunderstorm with rain ", "Búrka s dažďom"},
            {"thunderstorm with heavy rain", "Búrka so silným dažďom"},
            {"light thunderstorm ", "Búrka"},
            {"thunderstorm", "Búrka"},
            {"heavy thunderstorm", "Silná búrka"},
            {"ragged thunderstorm ", "ragged thunderstorm "},
            {"thunderstorm with light drizzle ", "thunderstorm with light drizzle "},
            {"thunderstorm with drizzle", "búrka s mrholením"},
            {"thunderstorm with heavy drizzle", "thunderstorm with heavy drizzle"},
            {"light intensity drizzle", "Slabe mrholenie"},
            {"drizzle", "mrholenie"},
            {"heavy intensity drizzle", "Silne mrholenie"},
            {"light intensity drizzle rain", "mrholenie"},
            {"drizzle rain", "mrholenie"},
            {"heavy intensity drizzle rain", "Silne mrholenie"},
            {"shower rain and drizzle", "Silne mrholenie"},
            {"heavy shower rain and drizzle", "Silne mrholenie"},
            {"shower drizzle", "Silne mrholenie"},
            {"light rain", "slabý dážď"},
            {"moderate rain", "mierny dážď"},
            {"heavy intensity rain", "silný dážď"},
            {"very heavy rain", "veľmi silný dážď"},
            {"extreme rain", "extrémny dážď"},
            {"freezing rain", "mrznúci dážď"},
            {"light intensity shower rain", "slabý dážď"},
            {"shower rain", "dážď"},
            {"heavy intensity shower rain", "dážď"},
            {"ragged shower rain", "dážď"},
            {"light snow", "Slabé sneženie"},
            {"Snow", "Sneženie"},
            {"Heavy snow", "Silné sneženie"},
            {"Sleet", "Sneženie"},
            {"Shower sleet", "Sneženie"},
            {"Light shower sleet", "Sneženie"},
            {"Light rain and snow ", "Slabý dážď a sneženie"},
            {"Rain and snow", "Dážď a sneženie"},
            {"Light shower snow", "Slabé sneženie"},
            {"Shower snow", "Silné sneženie"},
            {"Heavy shower snow", "Silné sneženie"},
            {"mist", "Hmlisto"},
            {"Haze", "Hmlisto"},
            {"clear sky", "Jasno"},
            {"few clouds", "Skoro jasno"},
            {"scattered clouds", "Polooblačno"},
            {"broken clouds", "Oblačno"},
            {"overcast clouds", "Zamračené"}
        };

    }
}