using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.DTOs.Usuarios;
using ProjetoJudo.Application.Notification;

namespace ProjetoJudo.Api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class AuthController : Controller
{
    private readonly IAuthService _autenticacaoService;
    private readonly INotificator _notificator;
    public AuthController(IAuthService autenticacaoService, INotificator notificator)
    {
        _autenticacaoService = autenticacaoService;
        _notificator = notificator;
    }
    
    [AllowAnonymous]
    [HttpPost("Registrar")]
    public async Task<IActionResult> Registrar([FromBody] RegistrarUsuarioDto dto)
    {
        var usuario = await _autenticacaoService.Registrar(dto);

        if (_notificator.HasError) return BadRequest(_notificator.Errors);
        return Ok(usuario);
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UsuarioAutenticadoDto.LoginUsuarioDto dto)
    {
        var autenticado = await _autenticacaoService.Autenticar(dto);

        if (_notificator.HasError) return new UnauthorizedResult();
        return Ok(autenticado);
    }
}