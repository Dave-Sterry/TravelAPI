using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class PacklistSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packlists",
                columns: table => new
                {
                    PacklistId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Items = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packlists", x => x.PacklistId);
                });

            migrationBuilder.InsertData(
                table: "Packlists",
                columns: new[] { "PacklistId", "Items" },
                values: new object[] { 1, "Some stuff to pack, clothes, toiletries" });

            migrationBuilder.InsertData(
                table: "Packlists",
                columns: new[] { "PacklistId", "Items" },
                values: new object[] { 2, "socks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packlists");
        }
    }
}
