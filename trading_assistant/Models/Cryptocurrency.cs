namespace trading_assistant.Models;

public class Cryptocurrency
{
    public int Id { get; set; }
    public string name { get; set; }
    public string symbol { get; set; }
    public string slug { get; set; }
    public int cmcRank { get; set; }
    public int numMarketPairs { get; set; }
    public decimal circulatingSupply { get; set; }
    public decimal totalSupply { get; set; }
    public decimal? maxSupply { get; set; }
    public DateTime lastUpdated { get; set; }
    public DateTime dateAdded { get; set; }
    public List<string> tags { get; set; }
    public Dictionary<string, Quote> Quotes { get; set; }
}