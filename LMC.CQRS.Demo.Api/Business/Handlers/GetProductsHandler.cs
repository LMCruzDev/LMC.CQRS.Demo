using LMC.CQRS.Demo.Api.Business.Queries;
using LMC.CQRS.Demo.Api.Data;
using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore fakeDataStore;

        public GetProductsHandler(FakeDataStore fakeDataStore) => this.fakeDataStore = fakeDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) => await fakeDataStore.GetAllProducts();
    }
}
