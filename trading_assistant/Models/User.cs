namespace trading_assistant.Models;
using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string userName { get; set; }
    public string email { get; set; }
    public string passwordHash { get; set; }
}