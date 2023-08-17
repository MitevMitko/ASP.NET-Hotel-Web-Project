using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Infrastructure.Migrations
{
    public partial class SeedAboutInfoAndContactsAndLandmarksTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutInfo",
                columns: new[] { "Id", "Description", "IsDeleted" },
                values: new object[] { new Guid("07c6dd15-8d67-409a-a281-862dde264da5"), "Hotel Little Vienna is located in Ruse, Bulgaria.", false });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "IsDeleted", "Phone" },
                values: new object[] { 1, "LittleVienna@mail.com", false, "+359886258316" });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "Description", "Distance", "IsDeleted", "Name" },
                values: new object[] { new Guid("4eb9fab4-9b37-4936-88ef-0195998922d5"), "One of the most beautiful caves in Bulgaria.", 45.0, false, "Orlova Chuka Cave" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutInfo",
                keyColumn: "Id",
                keyValue: new Guid("07c6dd15-8d67-409a-a281-862dde264da5"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("4eb9fab4-9b37-4936-88ef-0195998922d5"));
        }
    }
}
