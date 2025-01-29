using Colorama.Domain.Contracts.Interfaces;

namespace Colorama.Domain.Entities.Produtos;

public class Produtos : Entity, IAggregateRoot
{
    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public int Preco { get; set; }
    public int QuantidaDeemEstoque { get; set; }
    public CategoriaProdutos Categoria { get; set; }
    public string Fabricante { get; set; } = null!;
    public int CodigoProduto { get; set; } = null!;
    public DateOnly? DataDeValidade { get; set; }
}
