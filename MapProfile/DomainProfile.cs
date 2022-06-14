using AutoMapper;
using CQRS.Queries;
using System;

namespace CQRS.MapProfile
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(customer => customer.RegistrationDate, opt =>
                opt.MapFrom(_ => DateTime.Now));

            CreateMap<Customer, CustomerDto>()
                .ForMember(cd => cd.RegistrationDate, opt =>
                opt.MapFrom(c => c.RegistrationDate.ToShortDateString()));
        }
    }
}
