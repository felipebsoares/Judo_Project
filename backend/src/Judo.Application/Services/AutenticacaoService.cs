using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Judo.Application.Configuration;
using Judo.Application.Contracts.Services;
using Judo.Application.DTOs.Usuarios;
using Judo.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Judo.Application.Services;

public class AutenticacaoService : IAutenticacaoService
{
    private readonly IMapper _mapper;
    private readonly IPasswordHasher<Usuario> _passwordHasher;
    public AutenticacaoService(IPasswordHasher<Usuario> passwordHasher, IMapper mapper)
    {
        _passwordHasher = passwordHasher;
        _mapper = mapper;
    }
    
    public async Task<UsuarioDto?> Registrar(RegistrarUsuarioDto dto)
    {
        var usuario = _mapper.Map<Usuario>(dto);
       // var validacao = await _validator.ValidateAsync(usuario);

        //if (!validacao.IsValid)
       // {
           // _notificator.Handle(validacao.Errors);
          // return null;
      // }

        usuario.Senha = _passwordHasher.HashPassword(usuario, usuario.Senha);
     
        
       // _usuarioRepository.Cadastrar(usuario);
        
       // if (!await _usuarioRepository.UnitOfWork.Commit())
           // throw new Exception("Erro ao salvar no banco de dados");
        
        return _mapper.Map<UsuarioDto>(usuario);
    }

    public async Task<UsuarioAutenticadoDto?> Autenticar(LoginUsuarioDto dto)
    {
        var usuario = new Usuario(); //await _usuarioRepository.ObterPorEmail(dto.Email);
        if (usuario == null)
        {
       //     _notificator.Handle("Usuário ou Senha incorretos!");
            return null;
        }

        var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Senha, dto.Senha);
        if (result == PasswordVerificationResult.Failed)
        {
            //_notificator.Handle("Usuário ou Senha incorretos!");
            return null;
        }
        
        return new UsuarioAutenticadoDto
        {
            
            Email = usuario.Email,
            Nome = usuario.Nome,
            Token = GenerateToken(usuario)
        };
    }
    
    public static string GenerateToken(Usuario user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Settings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    
                new (ClaimTypes.NameIdentifier, user.Id.ToString()),
                new (ClaimTypes.Name, user.Nome),
                new (ClaimTypes.Role, user.Email)
            }),
            Expires = DateTime.UtcNow.AddHours(2),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}