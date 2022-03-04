using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Responses
{
    public class InvoiceItemResponse
    {
        public int Id { get; set; }
        public ProductResponse Product { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public int TaxRate { get; set; }
        public int DiscountRate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal LineTotal { get; set; }
    }
}
