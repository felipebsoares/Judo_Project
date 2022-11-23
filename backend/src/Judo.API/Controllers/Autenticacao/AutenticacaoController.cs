using Judo.Application.Contracts.Services;
using Judo.Application.DTOs.Usuarios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Judo.API.Controllers.Autenticacao;

[Authorize]
[ApiController]
[Route("[controller]")]
public class AutenticacaoController : Controller
{
    private readonly IAutenticacaoService _autenticacaoService;

    //private readonly INotificator _notificator;
    public AutenticacaoController(IAutenticacaoService autenticacaoService)
    {
        _autenticacaoService = autenticacaoService;
        //_notificator = notificator;
    }

    [HttpGet]
    public ActionResult Check()
    {
        return Ok();
    }

    [AllowAnonymous]
    [HttpPost("Registrar")]
    public async Task<IActionResult> Registrar([FromBody] RegistrarUsuarioDto dto)
    {
        var usuario = await _autenticacaoService.Registrar(dto);

        //if (_notificator.HasError) return BadRequest(_notificator.Errors);
        return Ok(usuario);
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUsuarioDto dto)
    {
        var autenticado = await _autenticacaoService.Autenticar(dto);

        //if (_notificator.HasError) return new UnauthorizedResult();
        return Ok(autenticado);
    }
}