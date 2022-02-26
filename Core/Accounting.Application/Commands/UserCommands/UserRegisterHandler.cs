using Accounting.Application.Interfaces.Repositories;
using Accounting.Application.Interfaces.Services;
using Accounting.Application.Responses;
using Accounting.Domain.Entites;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Accounting.Application.Commands.UserCommands
{
    public class UserRegisterHandler : IRequestHandler<UserRegisterCommand, UserResponse>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserRegisterHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<UserResponse> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
        {
            var userEntity = _mapper.Map<ApplicationUser>(request);
            if (userEntity == null)
                throw new ApplicationException("Entity could not be mapped!");

            var user = await _userService.CreateAsync(userEntity, request.Password);
            var userResponse = _mapper.Map<UserResponse>(user);
            return userResponse;
        }

    }
}
