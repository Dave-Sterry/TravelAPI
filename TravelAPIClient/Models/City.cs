using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelAPIClient.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Attraction { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public static List<City> GetCities()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<City> cityList = JsonConvert.DeserializeObject<List<City>>(jsonResponse.ToString());

            return cityList;
        }

        public static City GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            City city = JsonConvert.DeserializeObject<City>(jsonResponse.ToString());

            return city;
        }

        public static void Post(City city)
        {
            string jsonCity = JsonConvert.SerializeObject(city);
            var apiCallTask = ApiHelper.Post(jsonCity);
        }
    }
}