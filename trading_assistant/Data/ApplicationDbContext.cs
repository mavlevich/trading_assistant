using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using trading_assistant.Models;

namespace trading_assistant.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    public class User : IdentityUser
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Дополнительные настройки модели, если необходимо
    }
    
    
    public DbSet<HistoricalPrice> HistoricalPrices { get; set; }
    
    public class HistoricalPrice
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public decimal price { get; set; }
        public string cryptoId { get; set; }
    }
}