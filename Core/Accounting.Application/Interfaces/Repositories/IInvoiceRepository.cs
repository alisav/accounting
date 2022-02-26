using Accounting.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Application.Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        Task<IList<Invoice>> GetAllInvoicesAsync();
        Task<Invoice> GetInvoiceByIdAsync(int id);
        Task<Invoice> AddInvoiceAsync(Invoice invoice);
        Task UpdateInvoiceAsync(Invoice invoice);
        Task DeleteInvoiceAsync(int id);
        Task DeleteInvoiceAsync(Invoice invoice);
    }
}
