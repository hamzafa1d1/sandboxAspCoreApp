using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challengeApp.Migrations
{
    /// <inheritdoc />
    public partial class addedPaymentCardEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CardHolderId",
                table: "PaymentCardEntities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CardHolder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHolder", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCardEntities_CardHolderId",
                table: "PaymentCardEntities",
                column: "CardHolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentCardEntities_CardHolder_CardHolderId",
                table: "PaymentCardEntities",
                column: "CardHolderId",
                principalTable: "CardHolder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentCardEntities_CardHolder_CardHolderId",
                table: "PaymentCardEntities");

            migrationBuilder.DropTable(
                name: "CardHolder");

            migrationBuilder.DropIndex(
                name: "IX_PaymentCardEntities_CardHolderId",
                table: "PaymentCardEntities");

            migrationBuilder.DropColumn(
                name: "CardHolderId",
                table: "PaymentCardEntities");
        }
    }
}
