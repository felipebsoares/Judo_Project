using ProjetoJudo.Application.DTOs.Usuarios;

namespace ProjetoJudo.Application.Contracts.Services;

public interface IAuthService
{ 
    Task<UsuarioDto?> Registrar(RegistrarUsuarioDto dto);
    Task<UsuarioAutenticadoDto?> Autenticar(UsuarioAutenticadoDto.LoginUsuarioDto dto);
    
}