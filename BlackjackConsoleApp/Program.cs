
using System.Runtime.CompilerServices;
using System.Text.Json;

const string baseurl = "http://localhost:8080";
HttpClient http = new HttpClient();

JsonSerializerOptions joptions = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};

