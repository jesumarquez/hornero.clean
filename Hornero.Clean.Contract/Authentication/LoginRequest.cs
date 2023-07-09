namespace Hornero.Clean.Contract.Authentication
{
    public record LoginRequest(
        string Email,
        string Password
    );
}