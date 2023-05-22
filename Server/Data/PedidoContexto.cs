using Microsoft.EntityFrameworkCore;
using Proyecto.Shared.Modelo;

namespace Proyecto.Server.Data
{
 
        public class PedidoContexto : DbContext
        {
            public PedidoContexto(DbContextOptions<PedidoContexto> options) : base(options)
            {

            }

            public DbSet<Pedido> Pedidos { get; set; }


        }

}
