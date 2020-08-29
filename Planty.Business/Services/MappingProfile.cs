namespace Planty.Business.Services
{
    using AutoMapper;
    using Planty.Business.Models;
    using Entities = Planty.Data.Entities;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Product, Product>();
            CreateMap<Entities.User, User>();
        }
    }
}
