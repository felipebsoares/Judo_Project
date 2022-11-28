using AutoMapper;
using ProjetoJudo.Application.DTOs.Usuarios;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Application.Configuration;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<TbUsuario, RegistrarUsuarioDto>()
            .ReverseMap();
        CreateMap<TbUsuario, UsuarioDto>()
            .ReverseMap();
    }
}