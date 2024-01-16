namespace Meteo_Models
{
    public class Root
    {
        public int code { get; set; }
        public string msg { get; set; }
        public string time { get; set; }
        public Data data { get; set; }
        public override string ToString()
        {
            string str = " " +
            $"Codice: {code}\tmsg: {msg}\ttime: {time}\n" +
            $"Data: \n" +
            $"  Outdoor: \n" +
            $"      Temperature: \n" +
            $"          Time: {data.outdoor.temperature.time}" +
            $"          Unit: {data.outdoor.temperature.unit}" +
            $"          Value: {data.outdoor.temperature.value}\n" +
            $"      Feels Like: \n" +
            $"          Time: {data.outdoor.feels_like.time}" +
            $"          Unit: {data.outdoor.feels_like.unit}" +
            $"          Value: {data.outdoor.feels_like.value}\n" +
            $"      App Temp: \n" +
            $"          Time: {data.outdoor.app_temp.time}" +
            $"          Unit: {data.outdoor.app_temp.unit}" +
            $"          Value: {data.outdoor.app_temp.value}\n" +
            $"      Dew Point: \n" +
            $"          Time: {data.outdoor.dew_point.time}" +
            $"          Unit: {data.outdoor.dew_point.unit}" +
            $"          Value: {data.outdoor.dew_point.value}\n" +
            $"      Humidity: \n" +
            $"          Time: {data.outdoor.humidity.time}" +
            $"          Unit: {data.outdoor.humidity.unit}" +
            $"          Value: {data.outdoor.humidity.value}\n" +
            $"  Solar and Uvi: \n" +
            $"      solar: \n" +
            $"          Time: {data.solar_and_uvi.solar.time}" +
            $"          Unit: {data.solar_and_uvi.solar.unit}" +
            $"          Value: {data.solar_and_uvi.solar.value}\n" +
            $"      uvi: \n" +
            $"          Time: {data.solar_and_uvi.uvi.time}" +
            $"          Unit: {data.solar_and_uvi.uvi.unit}" +
            $"          Value: {data.solar_and_uvi.uvi.value}\n" +
            $"  Rainfall: \n" +
            $"      Rain Rate: \n" +
            $"          Time: {data.rainfall.rain_rate.time}" +
            $"          Unit: {data.rainfall.rain_rate.unit}" +
            $"          Value: {data.rainfall.rain_rate.value}\n" +
            $"      Daily: \n" +
            $"          Time: {data.rainfall.daily.time}" +
            $"          Unit: {data.rainfall.daily.unit}" +
            $"          Value: {data.rainfall.daily.value}\n" +
            $"      Event: \n" +
            $"          Time: {data.rainfall.@event.time}" +
            $"          Unit: {data.rainfall.@event.unit}" +
            $"          Value: {data.rainfall.@event.value}\n" +
            $"     Hourly: \n" +
            $"          Time: {data.rainfall.hourly.time}" +
            $"          Unit: {data.rainfall.hourly.unit}" +
            $"          Value: {data.rainfall.hourly.value}\n" +
            $"     Weekly: \n" +
            $"          Time: {data.rainfall.weekly.time}" +
            $"          Unit: {data.rainfall.weekly.unit}" +
            $"          Value: {data.rainfall.weekly.value}\n" +
            $"      Monthly: \n" +
            $"          Time: {data.rainfall.monthly.time}" +
            $"          Unit: {data.rainfall.monthly.unit}" +
            $"          Value: {data.rainfall.monthly.value}\n" +
            $"      Yearly: \n" +
            $"          Time: {data.rainfall.yearly.time}" +
            $"          Unit: {data.rainfall.yearly.unit}" +
            $"          Value: {data.rainfall.yearly.value}\n" +
            $"  Wind: \n" +
            $"      Wind Speed: \n" +
            $"          Time: {data.wind.wind_speed.time}" +
            $"          Unit: {data.wind.wind_speed.unit}" +
            $"          Value: {data.wind.wind_speed.value}\n" +
            $"      Wind Gust: \n" +
            $"          Time: {data.wind.wind_gust.time}" +
            $"          Unit: {data.wind.wind_gust.unit}" +
            $"          Value: {data.wind.wind_gust.value}\n" +
            $"      Wind Direction: \n" +
            $"          Time: {data.wind.wind_direction.time}" +
            $"          Unit: {data.wind.wind_direction.unit}" +
            $"          Value: {data.wind.wind_direction.value}\n" +
            $"  Battery: \n" +
            $"      Sensor Array: \n" +
            $"          Time: {data.battery.sensor_array.time}" +
            $"          Unit: {data.battery.sensor_array.unit}" +
            $"          Value: {data.battery.sensor_array.value}\n";
            return str;
        }
    }
    public class Data
    {
        public Outdoor outdoor { get; set; }
        public SolarAndUvi solar_and_uvi { get; set; }
        public Rainfall rainfall { get; set; }
        public Wind wind { get; set; }
        public Battery battery { get; set; }
    }
    public class Outdoor
    {
        public Temperature temperature { get; set; }
        public FeelsLike feels_like { get; set; }
        public AppTemp app_temp { get; set; }
        public DewPoint dew_point { get; set; }
        public Humidity humidity { get; set; }
    }
    public class SolarAndUvi
    {
        public Solar solar { get; set; }
        public Uvi uvi { get; set; }
    }
    public class Rainfall
    {
        public RainRate rain_rate { get; set; }
        public Daily daily { get; set; }
        public Event @event { get; set; }
        public Hourly hourly { get; set; }
        public Weekly weekly { get; set; }
        public Monthly monthly { get; set; }
        public Yearly yearly { get; set; }
    }
    public class Wind
    {
        public WindSpeed wind_speed { get; set; }
        public WindGust wind_gust { get; set; }
        public WindDirection wind_direction { get; set; }
    }
    public class Battery
    {
        public SensorArray sensor_array { get; set; }
    }

    public class AppTemp
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }


    public class Daily
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class DewPoint
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Event
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class FeelsLike
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Hourly
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Humidity
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Monthly
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class RainRate
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class SensorArray
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Solar
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Temperature
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Uvi
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Weekly
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class WindDirection
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class WindGust
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class WindSpeed
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Yearly
    {
        public string time { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
    }
}