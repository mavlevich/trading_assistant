namespace trading_assistant.Models;

public class HistoricalPrice
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public string CryptoId { get; set; }
}