namespace LibraryAppBackend.API.Options;

public class JwtOptions
{
    public string Audience { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string AccessTokenExpiration { get; set; } = string.Empty;
    public string SecretKey { get; set; } = string.Empty;
}