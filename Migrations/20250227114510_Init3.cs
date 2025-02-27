using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Table4U.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_TableId",
                table: "Reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TableId",
                table: "Reservation",
                column: "TableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_TableId",
                table: "Reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TableId",
                table: "Reservation",
                column: "TableId",
                unique: true);
        }
    }
}
