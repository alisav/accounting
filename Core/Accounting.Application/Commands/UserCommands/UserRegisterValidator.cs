using FluentValidation;

namespace Accounting.Application.Commands.UserCommands
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterCommand>
    {
        public UserRegisterValidator()
        {
            RuleFor(v => v.EMail)
                .NotEmpty();

            RuleFor(v => v.Password)
                .NotEmpty();
        }
    }
}
