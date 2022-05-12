using Microsoft.EntityFrameworkCore.Migrations;

namespace KursCollection.Data.Migrations
{
    public partial class Theme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Themes_ThemeId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThemeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThemeName",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "CollectionTheme",
                table: "Collections",
                newName: "ThemeId");

            migrationBuilder.AlterColumn<string>(
                name: "ThemeId",
                table: "Themes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThemeId",
                table: "Collections",
                newName: "CollectionTheme");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "Themes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ThemeName",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Items",
                type: "int",
                nullable: true);

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
    }
}
