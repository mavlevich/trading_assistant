namespace trading_assistant.Models;

public class Cryptocurrency
{
    // Tag or ID ?
    public string id { get; set; }
    public string symbol { get; set; }
    public string name { get; set; }
    public decimal currentPrice { get; set; }
    public List<CryptoPriceHistory> PriceHistory { get; set; }
}