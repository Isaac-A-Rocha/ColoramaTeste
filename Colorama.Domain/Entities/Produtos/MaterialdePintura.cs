namespace Colorama.Domain.Entities.Produtos;

public class MaterialdePintura : Produto
{
    public string Nome { get; set; } = null!; 
    public string Material { get; set; } = null!; 
    public string Tamanho { get; set; } = null!; 
    public bool Lavavel { get; set; } 
    
}
