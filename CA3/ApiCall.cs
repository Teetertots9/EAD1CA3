using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CA3
{
    public static class ApiCall
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.Headers.Add("Access-Control-Allow-Origin", "*"); //Allows for CORS in response headers
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
