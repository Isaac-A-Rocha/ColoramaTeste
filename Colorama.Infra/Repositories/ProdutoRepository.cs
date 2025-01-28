using Colorama.Domain.Abstractions;
using Colorama.Domain.Context;
using Colorama.Domain.Contracts.Repositories;
using Colorama.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace Colorama.Domain.Repositories;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(BaseApplicationDbContext context) : base(context)
    {
    }

    public void CadastrarProduto(Produto produto)
    {
        Context.Produtos.Add(produto);
    }

    public void AtualizarProduto(Produto produto)
    {
        Context.Produtos.Update(produto);
    }

    public async Task<Produto?> ObterProdutoPorId(int id)
    {
        return await Context.Produtos.AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<Produto>> ObterTodosProdutos()
    {
        return await Context.Produtos.AsNoTrackingWithIdentityResolution().ToListAsync();
    }

    public void ExcluirProduto(Produto produto)
    {
        Context.Produtos.Remove(produto);
    }
}
