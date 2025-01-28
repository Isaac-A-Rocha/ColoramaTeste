using Microsoft.AspNetCore.Mvc;
using Colorama.Application.Services;
using Colorama.Domain.Entities.Produtos;

namespace Colorama.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoService _produtoService;

    public ProdutosController(ProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [HttpPost]
    public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
    {
        if (produto == null)
            return BadRequest("Produto inválido.");

        try
        {
            var produtoCriado = await _produtoService.CriarProduto(produto);
            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produtoCriado.Id }, produtoCriado);
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao criar produto: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterProdutoPorId(int id)
    {
        var produto = await _produtoService.ObterProdutoPorId(id);

        if (produto == null)
            return NotFound("Produto não encontrado.");

        return Ok(produto);
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var produtos = await _produtoService.ObterTodos();
        return Ok(produtos);
    }
}
