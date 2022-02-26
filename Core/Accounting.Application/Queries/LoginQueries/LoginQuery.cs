using Accounting.Application.Responses;
using Accounting.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;

namespace Accounting.Application.Queries.LoginQueries
{
    public class LoginQuery : IRequest<LoginResponse>
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
