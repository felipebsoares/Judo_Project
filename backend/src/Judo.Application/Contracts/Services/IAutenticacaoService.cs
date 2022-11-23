using Judo.Application.DTOs.Usuarios;

namespace Judo.Application.Contracts.Services;

public interface IAutenticacaoService
{
    Task<UsuarioDto?> Registrar(RegistrarUsuarioDto dto);
    Task<UsuarioAutenticadoDto?> Autenticar(LoginUsuarioDto dto);
}