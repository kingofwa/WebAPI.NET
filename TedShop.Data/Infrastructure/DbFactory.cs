namespace TedShop.Data.Infrastructure
{
    public class DbFactory : Disposaple, IDbFactory
    {
        TeduShopDbContext dbContext;
        public TeduShopDbContext Iint()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
