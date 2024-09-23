namespace WebApiAuth.Models;

public sealed class Login
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
}
