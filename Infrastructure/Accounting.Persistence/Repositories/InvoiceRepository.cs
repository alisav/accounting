using Accounting.Application.Interfaces;
using Accounting.Application.Interfaces.Repositories;
using Accounting.Domain.Entites;
using Accounting.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Persistence.Repositories
{
    class InvoiceRepository : IInvoiceRepository
    {
        private readonly IAccountingDbContext context;

        public InvoiceRepository(IAccountingDbContext context)
        {
            this.context = context;
        }
        public void AddInvoice(Invoice invoice)
        {
            context.Invoices.Add(invoice);
            context.SaveChanges();
        }

        public void DeleteInvoice(int id)
        {
            Invoice invoice = GetInvoiceById(id);
            DeleteInvoice(invoice);
        }

        public void DeleteInvoice(Invoice invoice)
        {
            context.Invoices.Remove(invoice);
            context.SaveChanges();
        }

        public Invoice GetInvoiceById(int id)
        {
            return context.Invoices.Where(i => i.Id == id).FirstOrDefault();
        }

        public IList<Invoice> GetInvoices()
        {
            return context.Invoices.ToList();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            context.Invoices.Update(invoice);
            context.SaveChanges();
        }
    }
}
