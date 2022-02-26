using Accounting.Application.Responses;
using Accounting.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;

namespace Accounting.Application.Commands.InvoiceCommands
{
    public class InvoiceCreateCommand : IRequest<InvoiceResponse>
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public List<InvoiceItemCreateCommand> InvoiceItems { get; set; } = new List<InvoiceItemCreateCommand>();
    }

    public class InvoiceItemCreateCommand
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public int TaxRate { get; set; }
        public int DiscountRate { get; set; }
    }
}
