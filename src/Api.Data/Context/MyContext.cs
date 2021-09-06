using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<PedidoEntity> Pedido { get; set; }
        public DbSet<PedidoItemEntity> PedidoItem { get; set; }                        
        public DbSet<CategoriaEntity> Categoria { get; set; }                                                        
        public DbSet<UsuarioEntity> Usuario { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
