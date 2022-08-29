using LMC.CQRS.Demo.Api.Business.Commands;
using LMC.CQRS.Demo.Api.Business.Queries;
using LMC.CQRS.Demo.Api.Data.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LMC.CQRS.Demo.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IMediator mediator;

        public ProductsController(IMediator mediator) => this.mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await mediator.Send(new GetProductsQuery());

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            var addProductResult = await mediator.Send(new AddProductCommand(product));

            return CreatedAtRoute("GetProductById", new { id = addProductResult.Id }, addProductResult);
        }

        [HttpGet("{id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await mediator.Send(new GetProductByIdQuery(id));

            return Ok(product);
        }
    }
}
