using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Infrastructure.Migrations
{
    public partial class SeedRoomAndRoomRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "Id", "IsDeleted", "TypeName" },
                values: new object[,]
                {
                    { new Guid("6622b98e-2130-4633-b227-23de72bc0021"), false, "King Bed" },
                    { new Guid("7a644aea-e74a-49e2-baee-804a178a00b7"), false, "Queen Bed" },
                    { new Guid("ce9a5733-71b4-4d67-b0cd-01e909031d12"), false, "Bunk Bed" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, false, "TV" },
                    { 2, false, "Non-smoking room" },
                    { 3, false, "Smoking room" }
                });

            migrationBuilder.InsertData(
                table: "RoomAvailabilities",
                columns: new[] { "Id", "IsDeleted", "Type" },
                values: new object[,]
                {
                    { new Guid("181d6778-82ea-423b-b2da-c58fe3f33cbf"), false, "Booked" },
                    { new Guid("91520b6d-25f7-4a66-8650-e5644bc84a13"), false, "Available" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("30f9c331-274c-4316-918a-0dcadaf7b8d9"), false, "Economy" },
                    { new Guid("9df60366-5ad5-42f7-8c3f-bf8e1e5bc01e"), false, "Luxury" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedId", "Description", "FromDate", "IsDeleted", "Name", "PricePerNigth", "RoomAvailabilityId", "RoomTypeId", "ToDate" },
                values: new object[] { new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9"), new Guid("7a644aea-e74a-49e2-baee-804a178a00b7"), "Cozy and nice room on reasonable price per night.", null, false, "Mustang", 100m, new Guid("91520b6d-25f7-4a66-8650-e5644bc84a13"), new Guid("30f9c331-274c-4316-918a-0dcadaf7b8d9"), null });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedId", "Description", "FromDate", "IsDeleted", "Name", "PricePerNigth", "RoomAvailabilityId", "RoomTypeId", "ToDate" },
                values: new object[] { new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f"), new Guid("6622b98e-2130-4633-b227-23de72bc0021"), "Luxury and cozy room on reasonable price per night.", null, false, "Hortensia", 250m, new Guid("91520b6d-25f7-4a66-8650-e5644bc84a13"), new Guid("9df60366-5ad5-42f7-8c3f-bf8e1e5bc01e"), null });

            migrationBuilder.InsertData(
                table: "RoomsFacilities",
                columns: new[] { "FacilityId", "RoomId" },
                values: new object[,]
                {
                    { 1, new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9") },
                    { 3, new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9") },
                    { 1, new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f") },
                    { 2, new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "Id",
                keyValue: new Guid("ce9a5733-71b4-4d67-b0cd-01e909031d12"));

            migrationBuilder.DeleteData(
                table: "RoomAvailabilities",
                keyColumn: "Id",
                keyValue: new Guid("181d6778-82ea-423b-b2da-c58fe3f33cbf"));

            migrationBuilder.DeleteData(
                table: "RoomsFacilities",
                keyColumns: new[] { "FacilityId", "RoomId" },
                keyValues: new object[] { 1, new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9") });

            migrationBuilder.DeleteData(
                table: "RoomsFacilities",
                keyColumns: new[] { "FacilityId", "RoomId" },
                keyValues: new object[] { 3, new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9") });

            migrationBuilder.DeleteData(
                table: "RoomsFacilities",
                keyColumns: new[] { "FacilityId", "RoomId" },
                keyValues: new object[] { 1, new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f") });

            migrationBuilder.DeleteData(
                table: "RoomsFacilities",
                keyColumns: new[] { "FacilityId", "RoomId" },
                keyValues: new object[] { 2, new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f") });

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("acd6875f-a5ac-41ec-9b48-0d09655e01d9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c85bf0f6-0bbc-4eac-8944-115f6bafea9f"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "Id",
                keyValue: new Guid("6622b98e-2130-4633-b227-23de72bc0021"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "Id",
                keyValue: new Guid("7a644aea-e74a-49e2-baee-804a178a00b7"));

            migrationBuilder.DeleteData(
                table: "RoomAvailabilities",
                keyColumn: "Id",
                keyValue: new Guid("91520b6d-25f7-4a66-8650-e5644bc84a13"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("30f9c331-274c-4316-918a-0dcadaf7b8d9"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("9df60366-5ad5-42f7-8c3f-bf8e1e5bc01e"));
        }
    }
}
