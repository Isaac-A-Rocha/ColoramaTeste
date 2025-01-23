namespace Colorama.Domain.Entities;

public abstract class Entity : BaseEntity
{
    public DateTime CriadoEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
}

public abstract class BaseEntity
{ 
    public int Id { get; set; }
}