using System.Threading.Tasks;
using RestSharp;

namespace TravelAPIClient.Models
{
    class ApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"cities", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"cities/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task Post(string newCity)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"cities", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newCity);
            var response = await client.ExecuteTaskAsync(request);
        }
    }
}