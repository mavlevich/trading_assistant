namespace trading_assistant.Models;
using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string userName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}