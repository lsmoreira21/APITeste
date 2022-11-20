using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APITeste.Migrations
{
    public partial class ControllerCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteID",
                table: "Pedido",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteID",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Pedido");
        }
    }
}
