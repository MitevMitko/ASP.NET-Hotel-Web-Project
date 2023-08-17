using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Infrastructure.Migrations
{
    public partial class SeedActivitiesAndActivityCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivityCategories",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, false, "Fitness" },
                    { 2, false, "Horseback Riding" },
                    { 3, false, "Sauna" },
                    { 4, false, "Roupse Course" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategoryId", "Duration", "IsDeleted", "Price", "Title" },
                values: new object[] { 1, 1, 90.0, false, 10m, "Fitness" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategoryId", "Duration", "IsDeleted", "Price", "Title" },
                values: new object[] { 2, 2, 150.0, false, 60m, "Horseback Riding" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategoryId", "Duration", "IsDeleted", "Price", "Title" },
                values: new object[] { 3, 3, 120.0, false, 40m, "Sauna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActivityCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActivityCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActivityCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActivityCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
