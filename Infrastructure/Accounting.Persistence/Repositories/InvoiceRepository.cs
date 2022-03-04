using App.Application.Interfaces;
using App.Application.Interfaces.Repositories;
using App.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Persistence.Repositories
{
    class InvoiceRepository : IInvoiceRepository
    {
        private readonly IAccountingDbContext context;

        public InvoiceRepository(IAccountingDbContext context)
        {
            this.context = context;
        }
        public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
        {
            context.Invoices.Add(invoice);
            await context.SaveChangesAsync();
            return invoice;
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            Invoice invoice = await GetInvoiceByIdAsync(id);
            await DeleteInvoiceAsync(invoice);
        }

        public async Task DeleteInvoiceAsync(Invoice invoice)
        {
            context.Invoices.Remove(invoice);
            await context.SaveChangesAsync();
        }

        public async Task<Invoice> GetInvoiceByIdAsync(int id)
        {
            return await context.Invoices.FindAsync(id);
        }

        public async Task<IList<Invoice>> GetAllInvoicesAsync()
        {
            return await context.Invoices.ToListAsync();
        }

        public async Task UpdateInvoiceAsync(Invoice invoice)
        {
            context.Invoices.Update(invoice); 
            await context.SaveChangesAsync();
        }
    }
}
