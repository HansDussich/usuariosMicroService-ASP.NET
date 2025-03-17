using Microsoft.EntityFrameworkCore;
using usuariosMicroService.Models;

namespace usuariosMicroService.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
    
}
