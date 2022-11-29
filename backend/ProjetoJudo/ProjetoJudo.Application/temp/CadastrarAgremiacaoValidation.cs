using FluentValidation;
using ProjetoJudo.Application.DTOs.Agremiacoes;

namespace ProjetoJudo.Application.temp;

public class CadastrarAgremiacaoValidation : AbstractValidator<CadastrarAgremiacaoDto>
{
    public CadastrarAgremiacaoValidation()
    {
        RuleFor(c => c.Nome)
            .NotEmpty()
            .WithMessage("Nome não pode ser vazio!")
            .MaximumLength(80);
        RuleFor(c => c.Email)
            .NotEmpty()
            .WithMessage("Email não pode ser vazio!")
            .EmailAddress()
            .WithMessage("Email não é válido")
            .MaximumLength(80);
        RuleFor(c => c.Representante)
            .NotEmpty()
            .WithMessage("Representante não pode ser vazio!")
            .MaximumLength(80);
        RuleFor(c => c.Cnpj)
            .NotEmpty()
            .WithMessage("CNPJ não pode ser vazio!")
            .MaximumLength(80);
        RuleFor(c => c.Responsavel)
            .NotEmpty()
            .WithMessage("Responsavel não pode ser vazio!")
            .MaximumLength(80);
        RuleFor(c => c.Telefone)
            .NotEmpty()
            .WithMessage("Telefone não pode ser vazio!")
            .MaximumLength(80);
    }
}