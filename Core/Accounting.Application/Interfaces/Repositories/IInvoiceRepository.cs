using Accounting.Application.ViewModels;
using Accounting.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        IList<Invoice> GetInvoices();

        Invoice GetInvoiceById(int id);
        void AddInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int id);
        void DeleteInvoice(Invoice invoice);
    }
}
