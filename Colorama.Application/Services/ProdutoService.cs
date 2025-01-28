using Colorama.Domain.Entities.Produtos;
using Colorama.Infrastructure.Repositories;

namespace Colorama.Application.Services;

public class ProdutoService
{
    private readonly ProdutoRepository _produtoRepository;

    public ProdutoService(ProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<Produto> CriarProduto(Produto produto)
    {
        // Validar o tipo da entidade recebida
        if (produto is Tintas || produto is AcessoriosParaTintas || produto is Argamassas)
        {
            produto.CriadoEm = DateTime.UtcNow;
            produto.AtualizadoEm = DateTime.UtcNow;

            await _produtoRepository.Adicionar(produto);
            return produto;
        }
        else
        {
            throw new Exception("Tipo de produto inválido.");
        }
    }

    public async Task<Produto?> ObterProdutoPorId(int id)
    {
        return await _produtoRepository.ObterPorId(id);
    }

    public async Task<List<Produto>> ObterTodos()
    {
        return await _produtoRepository.ObterTodos();
    }
}
