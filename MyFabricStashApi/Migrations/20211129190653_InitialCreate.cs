using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFabricStashApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TotalLengthInches = table.Column<long>(type: "bigint", nullable: true),
                    FatQtrQty = table.Column<long>(type: "bigint", nullable: true),
                    TotalWidthInches = table.Column<long>(type: "bigint", nullable: true),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccentColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FabricType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FabricWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FabricContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcquiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialPurchaseInches = table.Column<long>(type: "bigint", nullable: true),
                    InitialPurchaseAmountPaid = table.Column<double>(type: "float", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Collection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fabrics_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fabrics_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_MainCategoryId",
                table: "Fabrics",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fabrics_SubCategoryId",
                table: "Fabrics",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fabrics");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
