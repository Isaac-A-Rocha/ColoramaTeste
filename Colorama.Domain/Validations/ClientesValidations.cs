using Colorama.Domain.Entities;
using FluentValidation;

namespace Colorama.Domain.Validations;

public class ClientesValidations : AbstractValidator<Clientes>
{
    public ClientesValidations()
    {
        RuleFor(u => u.Nome)
            .NotEmpty().WithMessage("O campo Nome é obrigatório.")
            .Length(3, 100).WithMessage("O campo Nome deve conter 3 a 100 caracteres")
            .Matches("^[a-zA-ZÀ-ÿ ]+$").WithMessage("O campo Nome deve conter somente letras.");

        RuleFor(u => u.Cpf)
            .NotEmpty().WithMessage("O campo Cpf é obrigatório.");

        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("O campo E-mail é obrigatório.")
            .Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$").WithMessage("O campo E-mail deve ser um endereço de e-mail válido.");
        
        RuleFor(u => u.Senha)
            .NotEmpty().WithMessage("O campo Senha é obrigatório.")
            .Length(8, 20).WithMessage("A senha deve ter entre 8 e 20 caracteres.")
            .Matches(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,20}$")
            .WithMessage("A senha deve conter letras, números, símbolos e ter entre 8 e 20 caracteres.");

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage("O campo telefone não pode ser vazio.");

        RuleFor(u => u.DataDeNascimento)
            .NotEmpty().WithMessage("O campo Data de Nascimento é obrigatório.")
            .WithMessage("Você deve ter 45 anos ou mais para se cadastrar.");
        
        RuleFor(u => u.Endereço)
            .NotEmpty().WithMessage("O campo endereço é obrigatório.")
            .Length(5, 50).WithMessage("O campo Nome deve conter 5 a 50 caracteres");
        
        RuleFor(u => u.Complemento)
            .NotEmpty().WithMessage("O campo Nome é obrigatório.")
            .Length(3, 15).WithMessage("O campo complemento deve conter 3 a 15 caracteres");
        
        RuleFor(x => x.Cep)
            .NotEmpty().WithMessage("O CEP não pode estar vazio.")
            .Length(8).WithMessage("O CEP deve conter exatamente 8 caracteres.")
            .Matches("^[0-9]{8}$").WithMessage("O CEP deve conter apenas números.");

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage("O campo cidade é necessário.")
            .MinimumLength(3)
            .WithMessage("O campo cidade deve ter no mínimo 3 caracteres");

        RuleFor(x => x.Estado)
            .NotEmpty()
            .WithMessage("O campo estado é necessário.")
            .MinimumLength(2)
            .WithMessage("O campo estado deve ter no mínimo 3 caracteres")
            .MaximumLength(50)
            .WithMessage("O campo estado deve ter no máximo 50 caracteres");

    }
}

public class AtualizarClientesValidation : AbstractValidator<Clientes>
{
    public AtualizarClientesValidation()
    {
        RuleFor(u => u.Nome)
            .NotEmpty().WithMessage("O campo Nome é obrigatório.")
            .Length(3, 100).WithMessage("O campo Nome deve conter 3 a 100 caracteres")
            .Matches("^[a-zA-ZÀ-ÿ ]+$").WithMessage("O campo Nome deve conter somente letras.");

        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("O campo E-mail é obrigatório.")
            .Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$").WithMessage("O campo E-mail deve ser um endereço de e-mail válido.");

        RuleFor(u => u.DataDeNascimento)
            .NotEmpty().WithMessage("O campo Data de Nascimento é obrigatório.");
    }
}

public class SenhaClienteValidator : AbstractValidator<string>
{
    public SenhaClienteValidator()
    {
        RuleFor(s => s)
            .NotEmpty().WithMessage("O campo Senha é obrigatório.")
            .Length(8, 20).WithMessage("A senha deve ter entre 8 e 20 caracteres.")
            .Matches(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,20}$")
            .WithMessage("A senha deve conter letras, números, símbolos e ter entre 8 e 20 caracteres.");
    }
}