using Accounting.Application.Interfaces;
using Accounting.Application.Interfaces.Repositories;
using Accounting.Application.Responses;
using Accounting.Domain.Entites;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Accounting.Application.Commands.InvoiceCommands
{
    public class InvoiceCreateHandler : IRequestHandler<InvoiceCreateCommand, InvoiceResponse>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public InvoiceCreateHandler(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }

        public async Task<InvoiceResponse> Handle(InvoiceCreateCommand request, CancellationToken cancellationToken)
        {
            var invoiceEntity = _mapper.Map<Invoice>(request);
            if (invoiceEntity == null)
                throw new ApplicationException("Entity could not be mapped!");

            var invoice = await _invoiceRepository.AddInvoiceAsync(invoiceEntity);
            var invoiceResponse = _mapper.Map<InvoiceResponse>(invoice);
            return invoiceResponse;
        }

    }
}
