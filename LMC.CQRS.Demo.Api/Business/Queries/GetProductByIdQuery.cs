using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
