namespace trading_assistant.Models;

public class Cryptocurrency
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string Slug { get; set; }
    public int CmcRank { get; set; }
    public int NumMarketPairs { get; set; }
    public decimal CirculatingSupply { get; set; }
    public decimal TotalSupply { get; set; }
    public decimal? MaxSupply { get; set; }
    public DateTime LastUpdated { get; set; }
    public DateTime DateAdded { get; set; }
    public List<string> Tags { get; set; }
    public Dictionary<string, Quote> Quotes { get; set; }
}