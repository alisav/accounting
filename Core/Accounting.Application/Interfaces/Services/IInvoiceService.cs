using Accounting.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interfaces.Services
{
    public interface IInvoiceService
    {
        IList<InvoiceResponse> GetInvoices();
        void AddInvoice(InvoiceResponse invoice);
        void UpdateInvoice(InvoiceResponse invoice);
        void DeleteInvoice(int id);
        void DeleteInvoice(InvoiceResponse invoice);
    }
}
