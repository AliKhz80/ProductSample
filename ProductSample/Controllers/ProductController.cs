using Application.Features.Product.Commands.CreateProductWithRelations;
using Application.Features.Product.Queries.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProductSample.Controllers
{
    public class ProductController(IMediator mediator) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new GetProductWithRelationsDataByIdQuery(id), cancellationToken);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateProductWithRelationsCommand request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
