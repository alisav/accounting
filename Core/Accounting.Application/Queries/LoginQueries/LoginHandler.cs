using App.Application.Interfaces.Repositories;
using App.Application.Interfaces.Services;
using App.Application.Responses;
using App.Domain.Entites;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Queries.LoginQueries
{
    public class LoginHandler : IRequestHandler<LoginQuery, LoginResponse>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var userEntity = _mapper.Map<ApplicationUser>(request);
            if (userEntity == null)
                throw new ApplicationException("Entity could not be mapped!");

            var user = await _userService.CreateAsync(userEntity, request.Password);
            var userResponse = _mapper.Map<LoginResponse>(user);
            return userResponse;
        }

    }
}
