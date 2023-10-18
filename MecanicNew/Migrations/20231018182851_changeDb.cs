using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecanicNew.Migrations
{
    /// <inheritdoc />
    public partial class changeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairDesciription_RepairSelects_RepairSelectsId",
                table: "RepairDesciription");

            migrationBuilder.DropIndex(
                name: "IX_RepairDesciription_RepairSelectsId",
                table: "RepairDesciription");

            migrationBuilder.DropColumn(
                name: "RepairSelectsId",
                table: "RepairDesciription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepairSelectsId",
                table: "RepairDesciription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RepairDesciription_RepairSelectsId",
                table: "RepairDesciription",
                column: "RepairSelectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairDesciription_RepairSelects_RepairSelectsId",
                table: "RepairDesciription",
                column: "RepairSelectsId",
                principalTable: "RepairSelects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
