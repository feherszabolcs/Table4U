using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Table4U.Migrations
{
    /// <inheritdoc />
    public partial class TableModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Table");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Table",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
