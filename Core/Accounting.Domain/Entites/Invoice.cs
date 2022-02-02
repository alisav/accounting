using Accounting.Domain.Entites.Base;
using System;
using System.Collections.Generic;

namespace Accounting.Domain.Entites
{
    public class Invoice : Entity
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }

        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    }
}
