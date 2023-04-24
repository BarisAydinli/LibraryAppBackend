namespace LibraryAppBackend.Infrastructure.Options;

public class JwtOptions
{
    public string Audience { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string AccessTokenExpiration { get; set; }
    public string SecurityKey { get; set; } = string.Empty;
}