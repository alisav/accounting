using App.Domain.Entites.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entites
{
    public class Customer : Entity
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        [Column(TypeName ="decimal(18,6)")]
        public decimal Debit { get; set; }
        [Column(TypeName ="decimal(18,6)")]
        public decimal Credit { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal Balance { get; set; }
    }
}
