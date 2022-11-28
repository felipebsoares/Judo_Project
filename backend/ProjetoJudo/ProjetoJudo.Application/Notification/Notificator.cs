using FluentValidation.Results;

namespace ProjetoJudo.Application.Notification;

public class Notificator : INotificator
{
    private bool _notFoundResource;
    private readonly List<string> _errors = new();

    public void Handle(string message)
    {
        _errors.Add(message);
    }

    public void Handle(List<ValidationFailure> failures)
    {
        failures.ForEach(failure => Handle(failure.ErrorMessage));
    }

    public void HandleNotFoundResource()
    {
        _notFoundResource = true;
    }

    public bool HasError => _errors.Any();
    public IReadOnlyCollection<string> Errors => _errors.AsReadOnly();
    public bool IsNotFoundResource => _notFoundResource;
}