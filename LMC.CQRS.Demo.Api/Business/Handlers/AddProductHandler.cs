using LMC.CQRS.Demo.Api.Business.Commands;
using LMC.CQRS.Demo.Api.Data;
using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;

namespace LMC.CQRS.Demo.Api.Business.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore fakeDataStore;

        public AddProductHandler(FakeDataStore fakeDataStore) => this.fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await fakeDataStore.AddProduct(request.Product);

            return request.Product;
        }
    }
}
