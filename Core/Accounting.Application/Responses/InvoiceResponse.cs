using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Responses
{
    public class InvoiceResponse
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public CustomerResponse Customer { get; set; }
        public List<InvoiceItemResponse> InvoiceItems { get; set; } = new List<InvoiceItemResponse>();
    }
}
