using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challengeApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentCardEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCardEntities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCardEntities_CardName",
                table: "PaymentCardEntities",
                column: "CardName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentCardEntities");
        }
    }
}
