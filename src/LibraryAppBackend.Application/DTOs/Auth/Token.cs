namespace LibraryAppBackend.Application.DTOs.Auth;

public sealed class AccessToken
{
    public string Token { get; set; } = string.Empty;
    public DateTime Expiration { get; set; }
}