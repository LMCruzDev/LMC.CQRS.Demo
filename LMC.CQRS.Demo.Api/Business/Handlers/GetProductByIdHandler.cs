using LMC.CQRS.Demo.Api.Business.Queries;
using LMC.CQRS.Demo.Api.Data;
using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore fakeDataStore;

        public GetProductByIdHandler(FakeDataStore fakeDataStore) => this.fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
            await fakeDataStore.GetProductById(request.Id);

    }
}
