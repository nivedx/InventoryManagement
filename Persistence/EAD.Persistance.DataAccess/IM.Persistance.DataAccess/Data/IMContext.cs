namespace IM.Persistance.DataAccess
{
    using Microsoft.EntityFrameworkCore;

    public class IMContext : DbContext
    {
        public IMContext()
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public IMContext(DbContextOptions<IMContext> options)
            : base(options)
        {

        }
        public IMContext(IMContext context)
        {
            context.Database.Migrate();
        }       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ATT-LP-724;database=InventoryManagement;Integrated Security=True;");
        }
    }
}
