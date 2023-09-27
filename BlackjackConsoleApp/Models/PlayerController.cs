using System.Text.Json;

namespace BlackjackConsoleApp
{
    public static class PlayerController
    {
        private static string baseurl = "http://localhost:8080";

        private static HttpClient http = new HttpClient();

        private static JsonSerializerOptions joptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public static async Task<JsonResponse> PlayerLoginAsync(string username, string password)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseurl}/api/players/{username}/{password}");
            HttpResponseMessage res = await http.SendAsync(req);
            var json = await res.Content.ReadAsStringAsync();
            Player? player;
            try
            {
                player = (Player?)JsonSerializer.Deserialize(json, typeof(Player), joptions);
            }
            catch
            {
                player = null;
            }
            return new JsonResponse
            {
                HttpStatusCode = (int)res.StatusCode,
                DataReturned = player
            };
        }

       public static async Task<JsonResponse> UpdatePlayer(Player play1)
        {
            
            HttpClient http = new HttpClient();
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Put, $"{baseurl}/api/players/{play1.Id}");
            var json = JsonSerializer.Serialize<Player>(play1, joptions);
            req.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage res = await http.SendAsync(req);
            return new JsonResponse()
            {
                HttpStatusCode = (int)res.StatusCode
            };
        }



    }
}
