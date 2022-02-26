using Accounting.Application.Responses;
using MediatR;

namespace Accounting.Application.Commands.UserCommands
{
    public class UserRegisterCommand : IRequest<UserResponse>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
