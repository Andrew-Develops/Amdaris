using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Module3Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Doe" },
                    { 2, "Jane", "Doe" },
                    { 3, "Bob", "Smith" },
                    { 4, "Alice", "Smith" },
                    { 5, "Tom", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A standard room with a queen-size bed and a private bathroom.", 99.99m, "Standard Room" },
                    { 2, "A deluxe room with a king-size bed, a private bathroom, and a balcony.", 149.99m, "Deluxe Room" },
                    { 3, "A suite with a king-size bed, a private bathroom, a living room, and a kitchenette.", 199.99m, "Suite" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomNumber", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 101, 1 },
                    { 2, 102, 1 },
                    { 3, 103, 2 },
                    { 4, 104, 2 },
                    { 5, 105, 3 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckedIn", "EndDate", "GuestId", "RoomId", "StartDate", "TotalCost" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 299.97m },
                    { 2, true, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 299.97m },
                    { 3, true, new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 449.95m },
                    { 4, true, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 449.95m },
                    { 5, true, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599.93m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
