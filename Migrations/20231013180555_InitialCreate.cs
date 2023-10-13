using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcLotion.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lotion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotionName = table.Column<string>(nullable: true),
                    LotionType = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    LaunchDate = table.Column<DateTime>(nullable: false),
                    Volume = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lotion");
        }
    }
}
