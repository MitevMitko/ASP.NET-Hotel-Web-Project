using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Infrastructure.Migrations
{
    public partial class SeedRoomServiceCategories_RoomServiceSubCategories_RoomServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomServiceCategories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Dishes" },
                    { 2, false, "Beverages" }
                });

            migrationBuilder.InsertData(
                table: "RoomServiceSubCategories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Desert" },
                    { 2, false, "Salad" },
                    { 3, false, "Soup" },
                    { 4, false, "Hot Drinks" },
                    { 5, false, "Cold Drinks" }
                });

            migrationBuilder.InsertData(
                table: "RoomServices",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "RoomServiceCategoryId", "RoomServiceSubCategoryId", "Weight" },
                values: new object[] { new Guid("7cc82cd1-b5c6-420d-9cea-d15ba4b09884"), "One of the most delicious bulgarian salad.", false, "Shopska Salata", 1, 2, 400m });

            migrationBuilder.InsertData(
                table: "RoomServices",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "RoomServiceCategoryId", "RoomServiceSubCategoryId", "Weight" },
                values: new object[] { new Guid("d0978ca5-e228-45e5-89d2-9e6ad507c464"), "Very nice hot drink.", false, "Hot Chocolate", 2, 4, 500m });

            migrationBuilder.InsertData(
                table: "RoomServices",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "RoomServiceCategoryId", "RoomServiceSubCategoryId", "Weight" },
                values: new object[] { new Guid("fab36e18-df9d-4161-b2e5-5a9fc71181f6"), "One of the most delicious bulgarian dish.", false, "Tarator", 1, 3, 400m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomServices",
                keyColumn: "Id",
                keyValue: new Guid("7cc82cd1-b5c6-420d-9cea-d15ba4b09884"));

            migrationBuilder.DeleteData(
                table: "RoomServices",
                keyColumn: "Id",
                keyValue: new Guid("d0978ca5-e228-45e5-89d2-9e6ad507c464"));

            migrationBuilder.DeleteData(
                table: "RoomServices",
                keyColumn: "Id",
                keyValue: new Guid("fab36e18-df9d-4161-b2e5-5a9fc71181f6"));

            migrationBuilder.DeleteData(
                table: "RoomServiceCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomServiceCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
