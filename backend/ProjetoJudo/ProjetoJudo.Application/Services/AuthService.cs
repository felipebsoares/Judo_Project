using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ProjetoJudo.Application.Configuration.Key;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.DTOs.Usuarios;
using ProjetoJudo.Application.Notification;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Application.Services;

public class AuthService : IAuthService
{
    private readonly INotificator _notificator;
    private readonly IValidator<TbUsuario> _validator;
    private readonly ITbUsuarioRepository _tbUsuarioRepository;
    private readonly IMapper _mapper;
    private readonly IPasswordHasher<TbUsuario> _passwordHasher;
    
    public AuthService(IPasswordHasher<TbUsuario> passwordHasher, IMapper mapper, ITbUsuarioRepository tbUsuarioRepository, INotificator notificator, IValidator<TbUsuario> validator)
    {
        _passwordHasher = passwordHasher;
        _mapper = mapper;
        _tbUsuarioRepository = tbUsuarioRepository;
        _notificator = notificator;
        _validator = validator;
    }
    
    public async Task<UsuarioDto?> Registrar(RegistrarUsuarioDto dto)
    {
        var usuario = _mapper.Map<TbUsuario>(dto);
       var validacao = await _validator.ValidateAsync(usuario);

        if (!validacao.IsValid)
        { 
            _notificator.Handle(validacao.Errors);
           return null;
       }

        usuario.Senha = _passwordHasher.HashPassword(usuario, usuario.Senha);
     
        
        _tbUsuarioRepository.Cadastrar(usuario);
        
       if (!await _tbUsuarioRepository.UnitOfWork.Commit())
           _notificator.Handle("Falha ao salvar no banco de dados!");
        
        return _mapper.Map<UsuarioDto>(usuario);
    }

    public async Task<UsuarioAutenticadoDto?> Autenticar(UsuarioAutenticadoDto.LoginUsuarioDto dto)
    {
        var usuario = await _tbUsuarioRepository.FistOrDefault(c => c.Email == dto.Email); //await _usuarioRepository.ObterPorEmail(dto.Email);
        if (usuario == null)
        {
            _notificator.Handle("Usuário ou Senha incorretos!");
            return null;
        }

        var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Senha, dto.Senha);
        if (result == PasswordVerificationResult.Failed)
        {
            _notificator.Handle("Usuário ou Senha incorretos!");
            return null;
        }
        
        return new UsuarioAutenticadoDto
        {
            
            Email = usuario.Email,
            Nome = usuario.Nome,
            Token = GenerateToken(usuario)
        };
    }
    
    public static string GenerateToken(TbUsuario user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Settings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new (ClaimTypes.NameIdentifier, user.IdUsuario.ToString()),
                new (ClaimTypes.Name, user.Nome),
                new (ClaimTypes.Role, user.Email)
            }),
            Expires = DateTime.UtcNow.AddMinutes(5),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}