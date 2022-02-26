using Accounting.Application.Commands.InvoiceCommands;
using Accounting.Application.Responses;
using Accounting.Domain.Entites;
using AutoMapper;

namespace Accounting.Application.Mapping
{
    class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Invoice, InvoiceResponse>().ReverseMap();
            CreateMap<Invoice, InvoiceCreateCommand>().ReverseMap();
            CreateMap<Invoice, InvoiceItemCreateCommand>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemResponse>().ReverseMap();

            CreateMap<Customer, CustomerResponse>().ReverseMap();

            CreateMap<Product, ProductResponse>().ReverseMap();
        }
    }
}
