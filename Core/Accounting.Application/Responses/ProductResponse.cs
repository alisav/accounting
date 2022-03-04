using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public decimal SentQuantity { get; set; }
        public decimal QuantityOnHand { get; set; }
    }
}
