namespace Catalog.API.Products.CreateProduct;

using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
public record CreateProductResult(Guid id);

internal class CreateProductCommandHandler
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Logica para se criar um produto usando as interfaces de Handler

        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price,
        };

        //Etapas relacionadas a bancos de dads/ Volta e faer

        return new CreateProductResult(Guid.NewGuid());

        throw new NotImplementedException();
    }
}

