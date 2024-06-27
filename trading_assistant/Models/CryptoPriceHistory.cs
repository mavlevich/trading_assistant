namespace trading_assistant.Models;

public class CryptoPriceHistory
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public decimal price { get; set; }
    public int cryptocurrencyId { get; set; }
    public Cryptocurrency cryptocurrency { get; set; }
}