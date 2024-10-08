using Domain.Interfaces;
using Domain.Models;
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
        public async Task<string> Handle(CreateProductWithRelationsCommand request, CancellationToken cancellationToken)
        {

            await unitOfWork.BeginTransactionAsync();
            try
            {
                #region Insert Product
                Domain.Models.Product product = new();
                product.ProductGroupId = request.ProductGroupId;
                product.WorkTypeId = request.WorkTypeId;
                product.ProductType = request.ProductType;
                product.Circulation = request.Circulation;
                product.CopyCount = request.CopyCount;
                product.PageCount = request.PageCount;
                product.PrintSide = request.PrintSide;
                product.IsCalculatePrice = request.IsCalculatePrice;
                product.IsCustomCirculation = request.IsCustomCirculation;
                product.IsCustomSize = request.IsCustomSize;
                product.IsCustomPage = request.IsCustomPage;
                product.MinCirculation = request.MinCirculation;
                product.MaxCirculation = request.MaxCirculation;
                product.MinPage = request.MinPage;
                product.MaxPage = request.MaxPage;
                product.MinWidth = request.MinWidth;
                product.MaxWidth = request.MaxWidth;
                product.MinLength = request.MinLength;
                product.MaxLength = request.MaxLength;
                product.SheetDimensionId = request.SheetDimensionId;
                product.FileExtension = request.FileExtension;
                product.IsCmyk = request.IsCmyk;
                product.CutMargin = request.CutMargin;
                product.PrintMargin = request.PrintMargin;
                product.IsCheckFile = request.IsCheckFile;
                #endregion

                #region Insert ProductAdt
                Domain.Models.ProductAdt productAdt = new();
                productAdt.AdtId = request.AdtId;
                productAdt.Required = request.Required;
                productAdt.Side = request.Side;
                productAdt.Count = request.Count;
                productAdt.IsJeld = request.IsJeld;
                #endregion
               
                #region ProductDeliver
                ProductDeliver productDeliver = new();
                productDeliver.Name = request.Name;
                productDeliver.isIncreased = request.isIncreased;
                productDeliver.StartCirculation = request.StartCirculation;
                productDeliver.EndCirculation = request.EndCirculation;
                productDeliver.PrintSide = request.ProductDeliverPrintSide;
                productDeliver.Price = request.ProductDeliverPrice;
                productDeliver.CalcType = request.CalcType;
                #endregion

                #region ProductJeld
                ProductJeld productJeld = new();
                productJeld.PrintSide = request.ProductJeldPrintSide;
                productJeld.FileExtension = request.FileExtension;
                productJeld.IsCmyk = request.ProductJeldIsCmyk;
                productJeld.CutMargin = request.ProductJeldCutMargin;
                productJeld.PrintMargin = request.ProductJeldPrintMargin;
                productJeld.IsCheckFile = request.ProductJeldIsCheckFile;
                #endregion

                #region ProductMaterial

                ProductMaterial productMaterial = new();
                productMaterial.MaterialId = request.MaterialId;
                productMaterial.Name = request.ProductMaterialName;
                productMaterial.IsJeld = request.ProductMaterialIsJeld;
                productMaterial.Required = request.ProductMaterialRequired;
                productMaterial.IsCustomCirculation = request.ProductMaterialIsCustomCirculation;
                productMaterial.IsCombinedMaterial = request.IsCombinedMaterial;
                productMaterial.Weight = request.Weight;

                #endregion

                #region ProductMaterialAttribute

                ProductMaterialAttribute productMaterialAttribute = new();
                productMaterialAttribute.MaterialAttributeId = request.MaterialAttributeId;
                #endregion

                #region ProductPrintKind

                ProductPrintKind productPrintKind = new();
                productPrintKind.PrintKindId = request.PrintKindId;
                productPrintKind.IsJeld = request.ProductPrintKindIsJeld;
                #endregion

                #region ProductSize

                ProductSize productSize = new();
                productSize.Length = request.Length;
                productSize.width = request.width;
                productSize.Name = request.Name;
                productSize.SheetCount = request.SheetCount;
                productSize.SheetDimensionId = request.SheetDimensionId;

                #endregion

                product.ProductAdts.Add(productAdt);
                product.ProductDelivers.Add(productDeliver);
                product.ProductJelds.Add(productJeld);

                //ProductMaterial
                productMaterial.ProductMaterialAttributes.Add(productMaterialAttribute);
                product.ProductMaterials.Add(productMaterial); 
                //...............
                product.ProductPrintKinds.Add(productPrintKind);
                product.ProductSizes.Add(productSize);

                await unitOfWork.productRepository.AddAsync(product);

                await unitOfWork.CommitAsync();

                #region Insert Remain Entities

                #region ProductAdtType
                ProductAdtType productAdtType = new();
                productAdtType.AdtTypeId = request.AdtTypeId;
                productAdtType.ProductAdtId = productAdt.Id;
                #endregion

                #region ProductDeliverSize
                ProductDeliverSize productDeliverSize = new();
                productDeliverSize.ProductSizeId = productSize.Id;
                productDeliverSize.ProductDeliverId = productDeliver.Id;
                #endregion

                #region ProductPrice

                ProductPrice productPrice = new();
                productPrice.Price = request.Price;
                productPrice.Circulation = request.ProductPriceCirculation;
                productPrice.IsDoubleSided = request.IsDoubleSided;
                productPrice.PageCount = request.ProductPricePageCount;
                productPrice.copyCount = request.ProductPriceCopyCount;
                productPrice.IsJeld = request.ProductPriceIsJeld;
                productPrice.ProductSizeId = productSize.Id;
                productPrice.ProductMaterialId = productMaterial.Id;
                productPrice.ProductMaterialAttributeId = productMaterialAttribute.Id;
                productPrice.ProductPrintKindId = productPrintKind.Id;
                #endregion

                #region ProductAdtPrice
                ProductAdtPrice productAdtPrice = new();
                productAdtPrice.price = request.ProductAdtprice;
                productAdtPrice.ProductPriceId = productPrice.Id;
                productAdtPrice.ProductAdtTypeId = productAdtType.Id;
                productAdtPrice.ProductAdtId = productAdt.Id;
                #endregion

                await unitOfWork.productAdtTypeRepository.AddAsync(productAdtType);
                await unitOfWork.productDeliverSizeRepository.AddAsync(productDeliverSize);
                await unitOfWork.productPriceRepository.AddAsync(productPrice);
                await unitOfWork.productAdtPriceRepository.AddAsync(productAdtPrice);

                await unitOfWork.CommitAsync();

                await unitOfWork.CommitTransactionAsync();

                #endregion

                return "request was successfully.";

            }
            catch (Exception)
            {
                await unitOfWork.RollbackAsync();
                throw;
            }
            finally
            {
                if(unitOfWork != null)
                    unitOfWork.Dispose();
            }
            


        }
    }
}
