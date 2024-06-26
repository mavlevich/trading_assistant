namespace trading_assistant.Models;

public class CryptoPriceHistory
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public int CryptocurrencyId { get; set; }
    public Cryptocurrency Cryptocurrency { get; set; }
}