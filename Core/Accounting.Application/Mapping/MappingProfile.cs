using Accounting.Application.ViewModels;
using Accounting.Domain.Entites;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Mapping
{
    class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Invoice, InvoiceResponse>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemResponse>().ReverseMap();
            CreateMap<Customer, CustomerResponse>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();
        }
    }
}
