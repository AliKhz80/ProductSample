using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.ViewModels
{
    public class ProductIWithRelationsViewModel
    {
        #region Product 
        public byte ProductType { get; set; }
        public string Circulation { get; set; } = string.Empty;
        public string CopyCount { get; set; } = string.Empty;
        public string PageCount { get; set; } = string.Empty;
        public byte PrintSide { get; set; }
        public bool IsCalculatePrice { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCustomSize { get; set; }
        public int IsCustomPage { get; set; }
        public int MinCirculation { get; set; }
        public int MaxCirculation { get; set; }
        public int MinPage { get; set; }
        public int MaxPage { get; set; }
        public double MinWidth { get; set; }
        public double MaxWidth { get; set; }
        public double MinLength { get; set; }
        public double MaxLength { get; set; }
        public int SheetDimensionId { get; set; }
        public string FileExtension { get; set; } = string.Empty;
        public bool IsCmyk { get; set; }
        public double CutMargin { get; set; }
        public double PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }
        #endregion

        #region product Adt

        public int AdtId { get; set; }
        public bool Required { get; set; }
        public byte Side { get; set; }
        public int Count { get; set; }
        public bool IsJeld { get; set; }

        #endregion

        #region ProductAdtPrice

        public double ProductAdtprice { get; set; }

        #endregion

        #region ProductAdtType

        public int AdtTypeId { get; set; }
        #endregion

        #region ProductDeliver

        public string Name { get; set; } = null!;
        public bool isIncreased { get; set; }
        public int StartCirculation { get; set; }
        public int EndCirculation { get; set; }
        public byte ProductDeliverPrintSide { get; set; }
        public double Price { get; set; }
        public byte CalcType { get; set; }

        #endregion

        #region ProductMaterial
        public int MaterialId { get; set; }
        public string ProductMaterialName { get; set; } = string.Empty;
        public bool ProductMaterialIsJeld { get; set; }
        public bool ProductMaterialRequired { get; set; }
        public bool ProductMaterialIsCustomCirculation { get; set; }
        public bool IsCombinedMaterial { get; set; }
        public int Weight { get; set; }


        #endregion

        #region ProductMaterialAttribute

        public int MaterialAttributeId { get; set; }


        #endregion

        #region ProductPrice

        public double price { get; set; }
        public int ProductPriceCirculation { get; set; }
        public int IsDoubleSided { get; set; }
        public int ProductPricePageCount { get; set; }
        public int copyCount { get; set; }
        public int ProductSizeId { get; set; }
        public int ProductMaterialId { get; set; }
        public int ProductMaterialAttributeId { get; set; }
        public int ProductPriceIsJeld { get; set; }
        public int ProductPrintKindId { get; set; }

        #endregion

        #region ProductPriceKind

        public int PrintKindId { get; set; }
        public bool ProductPriceKindIsJeld { get; set; }

        #endregion

        #region ProductSize

        public double Length { get; set; }
        public double width { get; set; }
        public string ProductSizeName { get; set; } = null!;
        public int SheetCount { get; set; }
        public int ProductSizeSheetDimensionId { get; set; }

        #endregion

    }
}
