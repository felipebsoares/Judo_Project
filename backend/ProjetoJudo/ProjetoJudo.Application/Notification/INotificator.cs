using FluentValidation.Results;

namespace ProjetoJudo.Application.Notification;

public interface INotificator
{
    void Handle(string message);
    void Handle(List<ValidationFailure> failures);
    bool HasError { get; }
    void HandleNotFoundResource();
    bool IsNotFoundResource { get; }
    IReadOnlyCollection<string> Errors { get; }
}