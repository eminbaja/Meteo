using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Meteo_Models;
using System.Threading;


namespace Meteo_Utils
{
    class Utils
    {
        static HttpClient client = new HttpClient();
        public static async Task<Root> getData()
        {
            string response = await client.GetStringAsync("https://api.ecowitt.net/api/v3/device/real_time?application_key=841C0A08B2E220090B328B73592ECF01&api_key=7a06d249-d6c3-4d77-b540-7bdb95ea28f3&mac=40:F5:20:0A:F7:7F&call_back=all");
            Root obj = JsonSerializer.Deserialize<Root>(response);
            return obj;
        }
    }
}