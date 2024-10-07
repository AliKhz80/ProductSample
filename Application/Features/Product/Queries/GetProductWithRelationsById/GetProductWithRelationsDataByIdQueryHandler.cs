using Application.Features.Product.ViewModels;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetProductById
{
    public class GetProductWithRelationsDataByIdQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetProductWithRelationsDataByIdQuery, ProductIWithRelationsViewModel>
    {
        public Task<ProductIWithRelationsViewModel> Handle(GetProductWithRelationsDataByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
