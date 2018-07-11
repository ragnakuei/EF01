using System.Data.Entity;


namespace EF01.EF
{
    public class NorthwindDbContext : DbContext
    {
        private NorthwindDbContext():base("ef") { } 

        public static NorthwindDbContext Create()
        {
            var dbContext = new NorthwindDbContext();
            dbContext.Configuration.LazyLoadingEnabled       = false;
            dbContext.Configuration.ProxyCreationEnabled     = false;
            dbContext.Configuration.AutoDetectChangesEnabled = false;
            return dbContext;
        }

        public virtual DbSet<Order>       Orders       { get; set; }
        public virtual DbSet<OrderDetail> OrderDetials { get; set; }
    }
}