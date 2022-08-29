using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
