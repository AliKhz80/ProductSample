using Application.Features.Product.Commands.CreateProductWithRelations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProductSample.Controllers
{
    public class ProductController(IMediator mediator) : ControllerBase
    {
       

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateProductWithRelationsCommand request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
