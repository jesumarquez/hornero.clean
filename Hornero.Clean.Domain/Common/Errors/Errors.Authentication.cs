using ErrorOr;

namespace Hornero.Clean.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Authentication
        {
            public static Error InvalidCredentials = Error.Conflict(
                code: "Auth.InvalidCredentials",
                description: "Invalid Credentials."
            );
        }
    }
}