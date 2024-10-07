using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Commands.CreateProductWithRelations
{
    public class CreateProductWithRelationsValidator : AbstractValidator<CreateProductWithRelationsCommand>
    {
        public CreateProductWithRelationsValidator()
        {
            #region Product Validation
            RuleFor(x => x.ProductGroupId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.WorkTypeId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductType).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.PrintSide).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.SheetDimensionId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.Circulation).Matches(Resources.RegexPatterns.Circulation).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.CopyCount).Matches(Resources.RegexPatterns.CopyCount).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.PageCount).Matches(Resources.RegexPatterns.PageCount).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.FileExtension).Matches(Resources.RegexPatterns.FileExtention).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.FileExtension).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.FileExtension).MaximumLength(50).WithMessage(Resources.Validations.StringLength);
            #endregion

            #region ProductAdt
            RuleFor(x => x.AdtId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            #endregion

            #region ProductAdtPrice
            RuleFor(x => x.ProductAdtprice).NotNull().WithMessage(Resources.Validations.RequiredProperty);

            #endregion

            #region ProductAdtType
            RuleFor(x => x.AdtTypeId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            #endregion

            #region ProductDeliver
            RuleFor(x => x.Name).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.Name).Matches(Resources.RegexPatterns.Name).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.Name).MaximumLength(50).WithMessage(Resources.Validations.StringLength);
            RuleFor(x => x.ProductDeliverPrintSide).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductDeliverPrice).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.CalcType).NotNull().WithMessage(Resources.Validations.RequiredProperty);

            #endregion

            #region ProductJeld

            RuleFor(x => x.ProductJeldPrintSide).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductJeldFileExtension).Matches(Resources.RegexPatterns.FileExtention).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.ProductJeldFileExtension).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductJeldFileExtension).MaximumLength(50).WithMessage(Resources.Validations.StringLength);

            #endregion

            #region ProductMaterial

            RuleFor(x => x.MaterialId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductMaterialName).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductMaterialName).Matches(Resources.RegexPatterns.Name).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.ProductMaterialName).MaximumLength(50).WithMessage(Resources.Validations.StringLength);

            #endregion

            #region ProductMaterialAttribute
            RuleFor(x => x.MaterialAttributeId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            #endregion

            #region ProductPrice

            RuleFor(x => x.Price).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductPriceCirculation).NotNull().WithMessage(Resources.Validations.RequiredProperty);

            #endregion

            #region ProductPrintKind

            RuleFor(x => x.PrintKindId).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductPriceCirculation).NotNull().WithMessage(Resources.Validations.RequiredProperty);

            #endregion

            #region ProductSize
            RuleFor(x => x.Length).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.width).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductSizeName).NotNull().WithMessage(Resources.Validations.RequiredProperty);
            RuleFor(x => x.ProductSizeName).Matches(Resources.RegexPatterns.Name).WithMessage(Resources.Validations.ReqularExpression);
            RuleFor(x => x.ProductSizeName).MaximumLength(50).WithMessage(Resources.Validations.StringLength);

            #endregion
        }
    }
}
