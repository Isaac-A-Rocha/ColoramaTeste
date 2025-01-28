namespace Colorama.Domain.Entities.Produtos;
public class Argamassas : Produto
{
    public string TipoArgamassa { get; set; } = null!; // Ex: AC1, AC2, AC3
    public bool UsoExterno { get; set; } // Para ambientes externos
    public int TempoCura { get; set; } // Tempo de cura em horas
    public bool Impermeabilizante { get; set; } // Se possui aditivos impermeabilizantes
    public string SuperficieIndicada { get; set; } = null!; // Ex: Porcelanato, Pedra Natural
    public decimal ResistênciaCarga { get; set; } // Em kg ou outro padrão
}
