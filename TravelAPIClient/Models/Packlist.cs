using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelAPIClient.Models
{
    public class Packlist
    {
        public int PacklistId { get; set; }
        public string Items { get; set; }

        public static List<Packlist> GetPacklists()
        {
            var apiCallTask = ApiHelperPacklists.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Packlist> packlistList = JsonConvert.DeserializeObject<List<Packlist>>(jsonResponse.ToString());

            return packlistList;
        }
    }
}