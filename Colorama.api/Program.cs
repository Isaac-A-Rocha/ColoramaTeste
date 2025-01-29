using Colorama.Application.Services;
using Colorama.Domain.Context;
using Colorama.Domain.Contracts.Repositories;
using Colorama.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BaseApplicationDbContext>(options =>
    options.UseInMemoryDatabase("ColoramaDb"))


builder.Services.AddScoped<IClientesRepository, ClienteRepository>();
builder.Services.AddScoped<IProdutosRepository, ProdutoRepository>();


builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ProdutoService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); 


