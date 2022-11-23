namespace Judo.Domain.Models;

public class Usuario : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public char Situacao { get; set; }
    public bool Selecao { get; set; }
}