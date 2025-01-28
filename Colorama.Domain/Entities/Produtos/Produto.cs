using Colorama.Domain.Contracts.Interfaces;

namespace Colorama.Domain.Entities.Produtos;

public class Produtos : Entity, IAggregateRoot
{
    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public CategoriaProdutos Categoria { get; set; }
    public string? Fabricante { get; set; } = null!;
    public string? CodigoProduto { get; set; } = null!;
    public DateOnly? DataDeValidade { get; set; }
}
