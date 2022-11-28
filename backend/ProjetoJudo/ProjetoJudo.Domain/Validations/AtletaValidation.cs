using FluentValidation;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Validations;

public class AtletaValidation : AbstractValidator<TbAtleta>
{
    public AtletaValidation()
    {
        RuleFor(at => at.RegistroFederacao)
            .MaximumLength(10)
            .WithMessage("O Registro Federação deve ter no máximo 10 caracteres")

            .NotNull()
            .WithMessage("O Registro Federação não pode ser nulo");

        RuleFor(at => at.RegistroConfederacao)
            .MaximumLength(10)
            .WithMessage("O Registro Federação deve ter no máximo 10 caracteres");
        
        RuleFor(at => at.Nome)
            .MaximumLength(60)
            .WithMessage("O nome deve ter no máximo 60 caracteres")

            .NotNull()
            .WithMessage("O nome não pode ser nulo");
        
        RuleFor(at => at.DataNascimento)
            .NotNull()
            .WithMessage("A data de nascimento não pode ser nula");
        
        RuleFor(at => at.DataFiliacao)
            .NotNull()
            .WithMessage("A data de filiação não pode ser nula");
        
        RuleFor(at => at.IdAgremiacao)
            .NotNull()
            .WithMessage("O IdAgremiacao não pode ser nulo");
        
        RuleFor(at => at.Cep)
            .MaximumLength(8)
            .WithMessage("O cep deve ter no máximo 8 caracteres")

            .NotNull()
            .WithMessage("O cep não pode ser nulo");
        
        RuleFor(at => at.Endereco)
            .MaximumLength(60)
            .WithMessage("O endereço deve ter no máximo 60 caracteres")

            .NotNull()
            .WithMessage("O endereço não pode ser nulo");

        RuleFor(at => at.Bairro)
            .MaximumLength(30)
            .WithMessage("O bairro deve ter no máximo 30 caracteres");
        
        RuleFor(at => at.Complemento)
            .MaximumLength(60)
            .WithMessage("O complemento deve ter no máximo 60 caracteres");
        
        RuleFor(at => at.IdCidade)
            .NotNull()
            .WithMessage("O IdCidade não pode ser nulo");
        
        RuleFor(at => at.IdEstado)
            .NotNull()
            .WithMessage("O IdEstado não pode ser nulo");
        
        RuleFor(at => at.IdPais)
            .NotNull()
            .WithMessage("O IdPais não pode ser nulo");
        
        RuleFor(at => at.Telefone)
            .MaximumLength(60)
            .WithMessage("O telefone deve ter no máximo 60 caracteres")

            .NotNull()
            .WithMessage("O telefone não pode ser nulo");
        
        RuleFor(at => at.Email)
            .MaximumLength(60)
            .WithMessage("O email deve ter no máximo 60 caracteres")

            .NotNull()
            .WithMessage("O email não pode ser nulo")
        
            .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
            .WithMessage("O email do usuario deve ser válido");
        
        RuleFor(at => at.Cpf)
            .MaximumLength(11)
            .WithMessage("O cpf deve ter no máximo 11 caracteres")

            .NotNull()
            .WithMessage("O cpf não pode ser nulo");
        
        RuleFor(at => at.Identidade)
            .MaximumLength(30)
            .WithMessage("A identidade deve ter no máximo 30 caracteres")

            .NotNull()
            .WithMessage("A identidade não pode ser nulo");
        
        RuleFor(at => at.DataIdentidade)
            .NotNull()
            .WithMessage("A DataIdentidade não pode ser nulo");
        
        RuleFor(at => at.IdEmissor)
            .NotNull()
            .WithMessage("O IdEmissor não pode ser nulo");
        
        RuleFor(at => at.IdNacionalidade)
            .NotNull()
            .WithMessage("O IdNacionalidade não pode ser nulo");
        
        RuleFor(at => at.IdProfissaoAtleta)
            .NotNull()
            .WithMessage("O IdProfissaoAtleta não pode ser nulo");

        RuleFor(at => at.NomePai)
            .MaximumLength(60)
            .WithMessage("O nome do pai deve ter no máximo 60 caracteres");

        RuleFor(at => at.NomeMae)
            .MaximumLength(60)
            .WithMessage("O nome da mãe deve ter no máximo 60 caracteres");

        RuleFor(at => at.IdFaixa)
            .NotNull()
            .WithMessage("O IdFaixa não pode ser nulo");
        
        RuleFor(at => at.IdSexo)
            .NotNull()
            .WithMessage("O IdSexo não pode ser nulo");
        
        RuleFor(at => at.IdEstadoCivil)
            .NotNull()
            .WithMessage("O IdEstadoCivil não pode ser nulo");

        RuleFor(at => at.Selecao)
            .NotNull()
            .WithMessage("A seleção não pode ser nula");
        
        RuleFor(at => at.IdCliente)
            .NotNull()
            .WithMessage("O IdCliente não pode ser nulo");
    }    
}