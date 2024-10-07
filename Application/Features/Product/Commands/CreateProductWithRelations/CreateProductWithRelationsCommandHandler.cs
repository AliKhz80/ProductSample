using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Commands.CreateProductWithRelations
{
    public class CreateProductWithRelationsCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateProductWithRelationsCommand, string>
    {
        public Task<string> Handle(CreateProductWithRelationsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
