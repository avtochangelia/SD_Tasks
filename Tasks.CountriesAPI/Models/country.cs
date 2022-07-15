namespace Tasks.CountriesAPI.Models;

public class country
{
    public name name { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public IEnumerable<decimal> latlng { get; set; }
    public decimal area { get; set; }
    public ulong population { get; set; }
}