using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<double>(type: "float", nullable: false),
                    Circulation = table.Column<int>(type: "int", nullable: false),
                    IsDoubleSided = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: true),
                    copyCount = table.Column<int>(type: "int", nullable: true),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    ProductMaterialId = table.Column<int>(type: "int", nullable: false),
                    ProductMaterialAttributeId = table.Column<int>(type: "int", nullable: true),
                    IsJeld = table.Column<int>(type: "int", nullable: false),
                    ProductPrintKindId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<byte>(type: "tinyint", nullable: false),
                    Circulation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopyCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintSide = table.Column<byte>(type: "tinyint", nullable: false),
                    IsCalculatePrice = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomCirculation = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomSize = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomPage = table.Column<int>(type: "int", nullable: true),
                    MinCirculation = table.Column<int>(type: "int", nullable: true),
                    MaxCirculation = table.Column<int>(type: "int", nullable: true),
                    MinPage = table.Column<int>(type: "int", nullable: true),
                    MaxPage = table.Column<int>(type: "int", nullable: true),
                    MinWidth = table.Column<double>(type: "float", nullable: true),
                    MaxWidth = table.Column<double>(type: "float", nullable: true),
                    MinLength = table.Column<double>(type: "float", nullable: true),
                    MaxLength = table.Column<double>(type: "float", nullable: true),
                    SheetDimensionId = table.Column<int>(type: "int", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCmyk = table.Column<bool>(type: "bit", nullable: false),
                    CutMargin = table.Column<double>(type: "float", nullable: false),
                    PrintMargin = table.Column<double>(type: "float", nullable: false),
                    IsCheckFile = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdtId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    Side = table.Column<byte>(type: "tinyint", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDelivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isIncreased = table.Column<bool>(type: "bit", nullable: false),
                    StartCirculation = table.Column<int>(type: "int", nullable: false),
                    EndCirculation = table.Column<int>(type: "int", nullable: false),
                    PrintSide = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CalcType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDelivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDelivers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductJelds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PrintSide = table.Column<byte>(type: "tinyint", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCmyk = table.Column<bool>(type: "bit", nullable: false),
                    CutMargin = table.Column<double>(type: "float", nullable: true),
                    PrintMargin = table.Column<double>(type: "float", nullable: true),
                    IsCheckFile = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductJelds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductJelds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomCirculation = table.Column<bool>(type: "bit", nullable: false),
                    IsCombinedMaterial = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrintKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PrintKindId = table.Column<int>(type: "int", nullable: false),
                    IsJeld = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrintKinds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrintKinds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    width = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SheetCount = table.Column<int>(type: "int", nullable: true),
                    SheetDimensionId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdtTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAdtId = table.Column<int>(type: "int", nullable: false),
                    AdtTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdtTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdtTypes_ProductAdts_ProductAdtId",
                        column: x => x.ProductAdtId,
                        principalTable: "ProductAdts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterialAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterialAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterialAttributes_ProductMaterials_ProductMaterialId",
                        column: x => x.ProductMaterialId,
                        principalTable: "ProductMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDeliverSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    ProductDeliverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDeliverSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDeliverSizes_ProductDelivers_ProductDeliverId",
                        column: x => x.ProductDeliverId,
                        principalTable: "ProductDelivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDeliverSizes_ProductSizes_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdtPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAdtId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    ProductPriceId = table.Column<int>(type: "int", nullable: false),
                    ProductAdtTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdtPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdtPrices_ProductAdtTypes_ProductAdtTypeId",
                        column: x => x.ProductAdtTypeId,
                        principalTable: "ProductAdtTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAdtPrices_ProductAdts_ProductAdtId",
                        column: x => x.ProductAdtId,
                        principalTable: "ProductAdts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAdtPrices_ProductPrices_ProductPriceId",
                        column: x => x.ProductPriceId,
                        principalTable: "ProductPrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrices_ProductAdtId",
                table: "ProductAdtPrices",
                column: "ProductAdtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrices_ProductAdtTypeId",
                table: "ProductAdtPrices",
                column: "ProductAdtTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrices_ProductPriceId",
                table: "ProductAdtPrices",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtTypes_ProductAdtId",
                table: "ProductAdtTypes",
                column: "ProductAdtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdts_ProductId",
                table: "ProductAdts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSizes_ProductDeliverId",
                table: "ProductDeliverSizes",
                column: "ProductDeliverId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSizes_ProductSizeId",
                table: "ProductDeliverSizes",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDelivers_ProductId",
                table: "ProductDelivers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductJelds_ProductId",
                table: "ProductJelds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterialAttributes_ProductMaterialId",
                table: "ProductMaterialAttributes",
                column: "ProductMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_ProductId",
                table: "ProductMaterials",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrintKinds_ProductId",
                table: "ProductPrintKinds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAdtPrices");

            migrationBuilder.DropTable(
                name: "ProductDeliverSizes");

            migrationBuilder.DropTable(
                name: "ProductJelds");

            migrationBuilder.DropTable(
                name: "ProductMaterialAttributes");

            migrationBuilder.DropTable(
                name: "ProductPrintKinds");

            migrationBuilder.DropTable(
                name: "ProductAdtTypes");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "ProductDelivers");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.DropTable(
                name: "ProductAdts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
