using AutoMapper;
using ProjetoJudo.Application.DTOs.Atleta;
using ProjetoJudo.Application.DTOs.Usuarios;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Application.Configuration;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region Usuario

        CreateMap<TbUsuario, RegistrarUsuarioDto>()
            .ReverseMap();
        CreateMap<TbUsuario, UsuarioDto>()
            .ReverseMap();

        #endregion

        #region Atleta

        CreateMap<TbAtleta, CreateAtletaDto>().ReverseMap();
        CreateMap<TbAtleta, AtletaDto>().ReverseMap();
        CreateMap<TbAtleta, UpdateAtletaDto>().ReverseMap();

        #endregion
    }
}