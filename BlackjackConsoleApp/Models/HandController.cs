using System;
using System.Security.Principal;
using System.Text.Json;

namespace BlackjackConsoleApp
{
	public static class HandController
	{
		private static string url = "http://localhost:8080/api/hands";

		private static HttpClient _http = new HttpClient();

        private static JsonSerializerOptions jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public static async Task PostHand(Hand hand)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);
            var json = JsonSerializer.Serialize(hand, jsonOptions);
            req.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            await _http.SendAsync(req);
            return;
        }
    }
}

