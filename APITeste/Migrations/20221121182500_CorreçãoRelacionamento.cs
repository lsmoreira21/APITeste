using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APITeste.Migrations
{
    public partial class CorreçãoRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoID",
                table: "ItemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_CLienteID",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CLienteID",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_PedidoID",
                table: "ItemPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CLienteID",
                table: "Pedido",
                column: "CLienteID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoID",
                table: "ItemPedido",
                column: "PedidoID");

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
    }
}
