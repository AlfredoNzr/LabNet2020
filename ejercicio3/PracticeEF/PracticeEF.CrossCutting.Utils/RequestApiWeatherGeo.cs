using Newtonsoft.Json;
using PracticeEF.CrossCutting.Utils.Api.GeoIP;
using PracticeEF.CrossCutting.Utils.Api.Weather;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeEF.CrossCutting.Utils
{
    public class RequestApiWeatherGeo
    {
        public string GetInfoWeather()
        {
            InfoGeo ApiLocationResult = new InfoGeo();

            City cityWeather = new City();
            try
            {
                ApiLocationResult = GetLocation(GetIp()); //retorna la ubicacion segun la IP

                cityWeather = GetWeather(ApiLocationResult.Location.City, ApiLocationResult.Location.Region.Name); //Retorna el tiempo en esa ciudad o region

                if (cityWeather._id != null)
                {
                    return ($"Ciudad: {cityWeather.name}, Por la mañana: {cityWeather.weather.morning_desc} Min:{cityWeather.weather.morning_temp}°|Max:{cityWeather.weather.afternoon_temp}°");
                }
                else
                {
                    return "error loading forecast";
                }

            }
            catch (Exception)
            {
                return "error loading forecast";
            }
            
        }

        private static string GetIp()
        {
            String htmlIpPublica = String.Empty;

            WebRequest solicitudWeb = WebRequest.Create("http://checkip.dyndns.org/");

            using (WebResponse respuestaWeb = solicitudWeb.GetResponse())
            using (StreamReader stream = new StreamReader(respuestaWeb.GetResponseStream()))
            {
                htmlIpPublica = stream.ReadToEnd();
            }

            Regex regexIp = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            MatchCollection resultado = regexIp.Matches(htmlIpPublica);

            string Ip = resultado[0].ToString();
            return Ip;

        }

        private static InfoGeo GetLocation(string Ip)
        {
            var url = $"https://api.ipregistry.co/{Ip}?key=p5ynn9rihtpzkx&fields=location";

            string responseBody = GetRequests(url);

            InfoGeo apiResponse = JsonConvert.DeserializeObject<InfoGeo>(responseBody);

            return apiResponse;
        }

        private static City GetWeather(string pCity, string pRegion)
        {
            var url = $"https://ws.smn.gob.ar/map_items/forecast/1";


            List<City> cities = new List<City>();

            string responseBody = GetRequests(url);

            cities = JsonConvert.DeserializeObject<List<City>>(responseBody);

            foreach (var city in cities)
            {
                if (city.name.ToLower() == pCity.ToLower())
                {
                    return city;
                }
            }
            return new City();
        }

        public static string GetRequests(string paramUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create(paramUrl);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return "Ocurrio un error";
            }

        }
    }
}
