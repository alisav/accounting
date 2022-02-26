using Accounting.Application.Commands.InvoiceCommands;
using Accounting.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Accounting.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<InvoiceController> _logger;

        public InvoiceController(IMediator mediator, ILogger<InvoiceController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [ProducesResponseType(typeof(InvoiceResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<InvoiceResponse>> OrderCreate([FromBody] InvoiceCreateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
