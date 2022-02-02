using Accounting.Domain.Entites.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entites
{
    public class InvoiceItem : Entity
    {
        public Product Product { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal Quantity { get; set; }
        public int TaxRate { get; set; }
        public int DiscountRate { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
    }
}
