using System.Threading;
using System.Threading.Tasks;
using ErrorOr;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.Entities;
using MediatR;
using Hornero.Clean.Domain.Common.Errors;

namespace Hornero.Clean.Application.Authentication.Queries.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public LoginQueryHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if(_userRepository.GetUserByEmail(request.Email) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            if(user.Password != request.Password)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            var token = _jwtTokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(
                User: user,
                Token: token
            );
        }
    }
}