namespace WebApiAuth.Models;

public sealed class Register
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
}
