using Colorama.Domain.Entities;

namespace Colorama.Domain.Contracts.Repositories;

public interface IClientesRepository : IRepository<Clientes>
{
    void CadastrarCliente(Clientes clientes);
    void AtualizarCliente(Clientes clientes);
    void ExcluirCliente(Clientes clientes);
    Task<Clientes?> ObterClientePorId(int id);
    Task<Clientes?> ObterClientePorEmail(string email);
    Task<List<Clientes>> ObterTodosClentes();
}
    
