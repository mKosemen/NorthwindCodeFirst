using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstNordwind.Migrations
{
    public partial class migo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShippersID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipVia",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShippersID",
                table: "Orders",
                newName: "ShipVia");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShippersID",
                table: "Orders",
                newName: "IX_Orders_ShipVia");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipVia",
                table: "Orders",
                column: "ShipVia",
                principalTable: "Shippers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipViaID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShipViaID",
                table: "Orders",
                newName: "ShippersID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShipViaID",
                table: "Orders",
                newName: "IX_Orders_ShippersID");

            migrationBuilder.AddColumn<int>(
                name: "ShipVia",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShippersID",
                table: "Orders",
                column: "ShippersID",
                principalTable: "Shippers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
