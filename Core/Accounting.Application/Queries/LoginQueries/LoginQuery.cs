using App.Application.Responses;
using App.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;

namespace App.Application.Queries.LoginQueries
{
    public class LoginQuery : IRequest<LoginResponse>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
