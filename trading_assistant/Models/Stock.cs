namespace trading_assistant.Models;

public class Stock
{
    public int id { get; set; }
    public string ticker { get; set; }
    public string name { get; set; }
    public decimal currentPrice { get; set; }
    public List<StockPriceHistory> priceHistory { get; set; }
}