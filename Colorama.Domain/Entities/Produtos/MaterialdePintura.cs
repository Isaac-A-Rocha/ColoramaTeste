namespace Colorama.Domain.Entities.Produtos;

public class MaterialdePintura : Produto
{
    public string TipoMaterial { get; set; } = null!;
    public string Tamanho { get; set; } = null!; 
    public string? Material { get; set; } 
    public string? IndicacaoUso { get; set; } 
    public bool? Reutilizavel { get; set; } 
    public string? Cor { get; set; } 
    public int QuantidadePorPacote { get; set; }
    public string? Compatibilidade { get; set; } 
    
}
