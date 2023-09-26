using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UnifaatTrabalhoDjalma4.Models;

namespace UnifaatTrabalhoDjalma4.Data
{
    public class ContextoDb : IdentityDbContext
    {
        public ContextoDb(DbContextOptions<ContextoDb> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<UnifaatTrabalhoDjalma4.Models.Produto>? Produto { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<UnifaatTrabalhoDjalma4.Models.Marca>? Marca { get; set; }

        public DbSet<Marca> Marcas { get; set; }



    }
}