using App.Application.Commands.InvoiceCommands;
using App.Application.Responses;
using App.Domain.Entites;
using AutoMapper;

namespace App.Application.Mapping
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
