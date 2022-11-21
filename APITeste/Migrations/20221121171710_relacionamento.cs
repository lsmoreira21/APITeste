using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APITeste.Migrations
{
    public partial class relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoID",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteID",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Pedido",
                newName: "CLienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido",
                newName: "IX_Pedido_CLienteID");

            migrationBuilder.AlterColumn<int>(
                name: "CLienteID",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PedidoID",
                table: "ItemPedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoID",
                table: "ItemPedido",
                column: "PedidoID",
                principalTable: "Pedido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_CLienteID",
                table: "Pedido",
                column: "CLienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoID",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_CLienteID",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "CLienteID",
                table: "Pedido",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_CLienteID",
                table: "Pedido",
                newName: "IX_Pedido_ClienteID");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Pedido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoID",
                table: "ItemPedido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoID",
                table: "ItemPedido",
                column: "PedidoID",
                principalTable: "Pedido",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteID",
                table: "Pedido",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID");
        }
    }
}
