using App.Domain.Entites.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entites
{
    public class Product : Entity
    {       
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal BuyPrice { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal SellPrice { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal ReceivedQuantity { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal SentQuantity { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal QuantityOnHand { get; set; }
    }
}
