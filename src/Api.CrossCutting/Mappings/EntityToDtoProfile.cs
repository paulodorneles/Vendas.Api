using Api.Domain.Dtos;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UsuarioDto, UsuarioEntity>()
               .ReverseMap();

            CreateMap<UsuarioRetornoDto, UsuarioEntity>()
               .ReverseMap();

         /*   CreateMap<UserDtoUpdateResult, UserEntity>()
               .ReverseMap();  */

            

        }
    }
}
