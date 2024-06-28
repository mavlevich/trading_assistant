namespace trading_assistant.Models;

public class Stock
{
    public int Id { get; set; }
    public string Ticker { get; set; }
    public string Name { get; set; }
    public decimal CurrentPrice { get; set; }
    public List<StockPriceHistory> PriceHistory { get; set; }
}