using FluentValidation;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Validations;

public class UsuarioValidation : AbstractValidator<TbUsuario>
{
    private readonly ITbUsuarioRepository _tbUsuarioRepository;
    public UsuarioValidation(ITbUsuarioRepository tbUsuarioRepository)
    {
        _tbUsuarioRepository = tbUsuarioRepository;
        //Adicionar mensagens de erro!
        RuleFor(c => c.Nome)
            .NotEmpty()
            .WithMessage("Nome não pode ser vazio!")
            .MaximumLength(80);
        RuleFor(c => c.Email)
            .NotEmpty()
            .WithMessage("Email não pode ser vazio!")
            .EmailAddress()
            .MaximumLength(80)
            .MustAsync(EmailEmUso);
        RuleFor(c => c.Senha)
            .NotEmpty()
            .WithMessage("Senha não pode ser vazia!")
            .MinimumLength(6);
        RuleFor(c => c)
            .Must(c => Check(c.Nome, c.Senha))
            .WithMessage("Nome não pode ser igual a senha!");
    }

    private bool Check(string nome, string senha)
    {
        return nome != senha;
    }

    private async Task<bool> EmailEmUso(string email, CancellationToken cancellationToken)
    {
        return await _tbUsuarioRepository.Any(c => c.Email == email);
    }
}