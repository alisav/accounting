using Accounting.Application.Interfaces.Repositories;
using Accounting.Application.Interfaces.Services;
using Accounting.Application.ViewModels;
using Accounting.Domain.Entites;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services
{
    class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IMapper mapper;

        public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            this.invoiceRepository = invoiceRepository;
            this.mapper = mapper;
        }
        public void AddInvoice(InvoiceResponse invoice)
        {
            var entity = mapper.Map<Invoice>(invoice);
            invoiceRepository.AddInvoice(entity);
        }

        public void DeleteInvoice(int id)
        {
            invoiceRepository.DeleteInvoice(id);
        }

        public void DeleteInvoice(InvoiceResponse invoice)
        {
            var entity = mapper.Map<Invoice>(invoice);
            invoiceRepository.DeleteInvoice(entity);
        }

        public IList<InvoiceResponse> GetInvoices()
        {
            var result = invoiceRepository.GetInvoices();
            return mapper.Map<IList<Invoice>, IList<InvoiceResponse>>(result);
        }

        public void UpdateInvoice(InvoiceResponse invoice)
        {
            var entity = mapper.Map<Invoice>(invoice);
            invoiceRepository.UpdateInvoice(entity);
        }
    }
}
