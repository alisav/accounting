using App.Application.Responses;
using MediatR;

namespace App.Application.Commands.UserCommands
{
    public class UserRegisterCommand : IRequest<UserResponse>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
