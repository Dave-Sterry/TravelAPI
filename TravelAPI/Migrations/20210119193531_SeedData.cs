using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Attraction", "Name", "Rating" },
                values: new object[] { 1, "Boeing", "Renton", 9 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Attraction", "Name", "Rating" },
                values: new object[] { 2, "Powells", "Portland", 8 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Attraction", "Name", "Rating" },
                values: new object[] { 3, "Magic Gardens", "Philadelphia", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);
        }
    }
}
