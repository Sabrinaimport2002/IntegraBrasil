using AutoMapper;
using IntegraBrasil.DTOs;
using IntegraBrasil.Models;

namespace IntegraBrasil.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}