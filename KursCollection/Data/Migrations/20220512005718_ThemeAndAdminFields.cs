using Microsoft.EntityFrameworkCore.Migrations;

namespace KursCollection.Data.Migrations
{
    public partial class ThemeAndAdminFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DarkTheme",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThemeId",
                table: "Items",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Themes_ThemeId",
                table: "Items",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "ThemeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Themes_ThemeId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThemeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DarkTheme",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AppUsers");
        }
    }
}
