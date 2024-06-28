namespace trading_assistant.Models;
using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}