using FluentValidation;

namespace Hornero.Clean.Application.Authentication.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.User.FirstName).NotEmpty(); 
            RuleFor(x => x.User.LastName).NotEmpty(); 
            RuleFor(x => x.User.Email).NotEmpty(); 
            RuleFor(x => x.User.Password).NotEmpty(); 
        }
    }
}