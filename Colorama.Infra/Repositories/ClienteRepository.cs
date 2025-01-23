using Colorama.Domain.Abstractions;
using Colorama.Domain.Context;
using Colorama.Domain.Contracts.Repositories;
using Colorama.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Colorama.Domain.Repositories;

public class ClienteRepository : Repository<Clientes>, IClientesRepository
{
    public ClienteRepository(BaseApplicationDbContext context) : base(context)
    {
    }

    public void CadastrarCliente(Clientes clientes)
    {
        Context.Clientes.Add(clientes);
    }

    public void AtualizarCliente(Clientes clientes)
    {
        Context.Clientes.Update(clientes);
    }

    public async Task<Clientes?> ObterClientePorId(int id)
    {
        return await Context.Clientes.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<Clientes?> ObterClientePorEmail(string email)
    {
        return await Context.Clientes.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<List<Clientes>> ObterTodosClentes()
    {
        return await Context.Clientes.AsNoTrackingWithIdentityResolution().ToListAsync();
    }
    
    public void ExcluirCliente(Clientes clientes)
    {
        Context.Clientes.Remove(clientes);
    }
}