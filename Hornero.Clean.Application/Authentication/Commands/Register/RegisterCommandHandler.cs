using System;
using System.Threading;
using System.Threading.Tasks;
using ErrorOr;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.Entities;
using MediatR;
using Hornero.Clean.Domain.Common.Errors;

namespace Hornero.Clean.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if(_userRepository.GetUserByEmail(request.User.Email) is not null)
            {
                return Errors.User.DuplicatedEmail;
            }

            var user = new User{
                FirstName = request.User.FirstName,
                LastName = request.User.LastName,
                Email = request.User.Email,
                Password = request.User.Password
            };

            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(
                User: user,
                Token: token
            );
        }
    }
}