using ChurchSystem.API;
using System;
using System.Windows;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;



public interface ITitheService
{
    public Task<List<Tithe>> GetAllTithe();
    public Task CreateTitheEntry(Tithe tithe);

}

public class TitheService : ITitheService
{
    private readonly HttpClient _httpClient;
    public TitheService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<Tithe>> GetAllTithe()
    {

        var titheResponse = await _httpClient.GetAsync("/tithe");
        if (titheResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return new List<Tithe>();
        }
        var responseContent = titheResponse.Content;
        var tithe = await responseContent.ReadFromJsonAsync<List<Tithe>>();
        return tithe.ToList();
    }

    public async Task CreateTitheEntry(Tithe tithe)
    {

        var titheJson = new StringContent(
            JsonSerializer.Serialize(tithe),
            Encoding.UTF8);

        using var data = await _httpClient.PostAsync("https://example.com", titheJson);
        data.EnsureSuccessStatusCode();
    }
}