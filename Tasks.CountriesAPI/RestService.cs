using RestSharp;
using System.Text.Json;
using Tasks.CountriesAPI.Models;

namespace Tasks.CountriesAPI;

public class RestService
{
    private readonly RestClient _client;

    public RestService(string baseUrl)
    {
        _client = new RestClient(baseUrl);
    }

    public async Task<List<country>> GetCountries(string resource)
    {
        try
        {
            var request = new RestRequest(resource, Method.Get);
            var response = await _client.ExecuteAsync(request);
            return JsonSerializer.Deserialize<List<country>>(response.Content);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}