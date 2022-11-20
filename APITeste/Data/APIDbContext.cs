using APITeste.Models;
using Microsoft.EntityFrameworkCore;

namespace APITeste.Data    
{
    public class APIDbContext: DbContext 
    {
        public APIDbContext (DbContextOptions<APIDbContext>options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<APITeste.Models.ItemPedido> ItemPedido { get; set; }

        public DbSet<APITeste.Models.Pedido> Pedido { get; set; }

    }
}
