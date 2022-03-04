using App.Application.Interfaces;
using App.Application.Interfaces.Repositories;
using App.Application.Responses;
using App.Domain.Entites;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Commands.InvoiceCommands
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
