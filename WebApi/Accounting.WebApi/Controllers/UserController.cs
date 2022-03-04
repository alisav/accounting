using App.Application.Commands.UserCommands;
using App.Application.Queries.LoginQueries;
using App.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebApi.Controllers
{
    [Route("api/v1/{controller}")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<InvoiceController> _logger;

        public UserController(IMediator mediator, ILogger<InvoiceController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginQuery query)
        {
            var result = await _mediator.Send(query);
            return result;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserResponse>> Register([FromBody] UserRegisterCommand command)
        {
            var result = await _mediator.Send(command);
            return result;
        }

    }
}
