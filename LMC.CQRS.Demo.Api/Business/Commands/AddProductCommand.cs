using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
