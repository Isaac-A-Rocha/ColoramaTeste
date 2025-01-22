namespace Colorama.Infra.Entities;

public class Clientes : Entity
{
    public string Nome { get; set; } = null!;
    public int Cpf { get; set; }
    public string Email { get; set; } = null!;
    public int Teleone { get; set; }
    public DateOnly DataDeNascimento { get; set; } 
    public string Senha { get; set; }  = null!;
    public string? TokenDeResetSenha { get; set; }
    public DateTime? ExpiraResetToken { get; set; }
    
}