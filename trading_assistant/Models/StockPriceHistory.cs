namespace trading_assistant.Models;

public class StockPriceHistory
{
    // Same problem, use tag or id ? 
    public int id { get; set; }
    public DateTime date { get; set; }
    public decimal price { get; set; }
    public int stockId { get; set; }
    public Stock stock { get; set; }
}