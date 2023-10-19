using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecanicNew.Migrations
{
    /// <inheritdoc />
    public partial class changesRepairTotalPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepairId",
                table: "RepairTotalPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "RepairTotalPrices");
        }
    }
}
