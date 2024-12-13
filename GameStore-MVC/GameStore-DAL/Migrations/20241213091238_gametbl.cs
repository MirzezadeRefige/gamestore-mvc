using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore_DAL.Migrations
{
    /// <inheritdoc />
    public partial class gametbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TrendingGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TrendingGames");
        }
    }
}
