using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlackjackConsoleApp.Models
{
    public class PlayerController
    {
        const string baseurl = "http://localhost:8080";
        // PLAYER LOGIN
        public static async Task<JsonResponse> PlayerLoginAsync(HttpClient http, JsonSerializerOptions joptions, string username, string password)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseurl}/api/players/{username}/{password}");
            HttpResponseMessage res = await http.SendAsync(req);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"Http ErrorCode: {res.StatusCode}");
            }
            var json = await res.Content.ReadAsStringAsync();
            var player = (Player?)JsonSerializer.Deserialize(json, typeof(Player), joptions);
            if (player is null) throw new Exception();
            return new JsonResponse
            {
                HttpStatusCode = (int)res.StatusCode,
                DataReturned = player
            };
        }



    }
}
