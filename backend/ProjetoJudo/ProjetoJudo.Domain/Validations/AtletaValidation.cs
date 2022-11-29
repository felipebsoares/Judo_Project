using FluentValidation;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Validations;

public class AtletaValidation : AbstractValidator<TbAtleta>
{
    public AtletaValidation()
    {
        RuleFor(a => a.Nome)
            .MaximumLength(60)
            .WithMessage("O nome deve ter no máximo 60 caracteres")
            .NotNull()
            .WithMessage("O nome não pode ser nulo")
            .NotEmpty()
            .WithMessage("O nome não pode ser vazio");
        
        RuleFor(a => a.DataNascimento)
            .NotNull()
            .WithMessage("A data de nascimento não pode ser nulo")
            .NotEmpty()
            .WithMessage("A data de nascimento não pode ser vazio");
        
        RuleFor(a => a.Telefone)
            .MaximumLength(60)
            .WithMessage("O telefone deve ter no máximo 60 caracteres")
            .NotNull()
            .WithMessage("O telefone não pode ser nulo")
            .NotEmpty()
            .WithMessage("O telefone não pode ser vazio");
        
        RuleFor(a => a.Email)
            .MaximumLength(60)
            .WithMessage("O email deve ter no máximo 60 caracteres")
            .NotNull()
            .WithMessage("O email não pode ser nulo")
            .NotEmpty()
            .WithMessage("O email não pode ser vazio")
            .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
            .WithMessage("O email deve ser válido");
        
        RuleFor(a => a.Cpf)
            .MaximumLength(60)
            .WithMessage("O cpf deve ter no máximo 60 caracteres")
            .NotNull()
            .WithMessage("O cpf não pode ser nulo")
            .NotEmpty()
            .WithMessage("O cpf não pode ser vazio");
    }
}