using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
	/// <inheritdoc />
	public partial class BlogMig1 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "BlogCategories",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					IsActive = table.Column<bool>(type: "bit", nullable: false),
					DataCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
					DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BlogCategories", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "BlogDetails",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					IsActive = table.Column<bool>(type: "bit", nullable: false),
					DataCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
					DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BlogDetails", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "BlogCategoryBlogDetail",
				columns: table => new
				{
					BlogCategoriesId = table.Column<int>(type: "int", nullable: false),
					BlogDetailsId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BlogCategoryBlogDetail", x => new { x.BlogCategoriesId, x.BlogDetailsId });
					table.ForeignKey(
						name: "FK_BlogCategoryBlogDetail_BlogCategories_BlogCategoriesId",
						column: x => x.BlogCategoriesId,
						principalTable: "BlogCategories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_BlogCategoryBlogDetail_BlogDetails_BlogDetailsId",
						column: x => x.BlogDetailsId,
						principalTable: "BlogDetails",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_BlogCategoryBlogDetail_BlogDetailsId",
				table: "BlogCategoryBlogDetail",
				column: "BlogDetailsId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "BlogCategoryBlogDetail");

			migrationBuilder.DropTable(
				name: "BlogCategories");

			migrationBuilder.DropTable(
				name: "BlogDetails");
		}
	}
}
