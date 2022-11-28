using FluentValidation.Results;

namespace ProjetoJudo.Domain.Entities;

public abstract class Base
{
    public int Id { get; set; }

    public virtual bool Validar(out ValidationResult validationResult)
    {
        validationResult = new ValidationResult();
        return validationResult.IsValid;
    }
}