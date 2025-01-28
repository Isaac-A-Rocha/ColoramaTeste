using Colorama.Domain.Entities.Produtos;

namespace Colorama.Domain.Contracts.Repositories;

public interface IProdutoRepository
{
    void CadastrarProduto(Produto produto);
    void AtualizarProduto(Produto produto);
    Task<Produto?> ObterProdutoPorId(int id);
    Task<List<Produto>> ObterTodosProdutos();
    void ExcluirProduto(Produto produto);
}
