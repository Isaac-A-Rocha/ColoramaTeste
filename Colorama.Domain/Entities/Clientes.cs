using Colorama.Infra.Entities;

namespace Colorama.Domain.Entities;

public class Clientes : Entity
{
    public string Nome { get; set; } = null!;
    public int Cpf { get; set; }
    public string Email { get; set; } = null!;
    public string Senha { get; set; }  = null!;
    public int? Telefone { get; set; }
    public DateOnly DataDeNascimento { get; set; } 
    public string Endereço { get; set; } = null!;
    public string Complemento { get; set; } = null!;
    public string Cep { get; set; } = null!;
    public string Cidade { get; set; } = null!;
    public string Estado { get; set; } = null!;
    
    public string? TokenDeResetSenha { get; set; }
    public DateTime? ExpiraResetToken { get; set; }
    
}