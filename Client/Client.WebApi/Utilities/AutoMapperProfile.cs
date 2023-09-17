using AutoMapper;
using Client.WebApi.DTOS;
using Client.WebApi.Models;
using System.Globalization;

namespace Client.WebApi.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            #region Clients
            CreateMap<Clients, ClientsDTO>()
                .ForMember(dt =>
                dt.IdClient,
                opt => opt.Ignore())

                .ForMember(dt =>
                dt.BirthDate,
                opt => opt.MapFrom(or => or.BirthDate.Value.ToString("dd/MM/yyyy")));

            CreateMap<ClientsDTO, Clients>()
                .ForMember(dt =>
                dt.IdClient,
                opt => opt.Ignore())

                .ForMember(dt =>
                dt.BirthDate,
                opt => opt.MapFrom(or => or.BirthDate.Value.ToString("dd/MM/yyyy")));
            #endregion
        }
    }
}
