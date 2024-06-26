namespace trading_assistant.Models;

public class Quote
{
    public decimal price { get; set; }
    public decimal volume24h { get; set; }
    public decimal percentChange1h { get; set; }
    public decimal percentChange24h { get; set; }
    public decimal percentChange7d { get; set; }
    public decimal marketCap { get; set; }
    public DateTime lastUpdated { get; set; }
}