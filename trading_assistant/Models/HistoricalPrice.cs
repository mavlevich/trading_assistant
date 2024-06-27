namespace trading_assistant.Models;

public class HistoricalPrice
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public decimal price { get; set; }
    public string cryptoId { get; set; }
}