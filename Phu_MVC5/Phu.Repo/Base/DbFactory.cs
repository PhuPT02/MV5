namespace Phu.Data.Base
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PhuDBContext dbContext;

        public PhuDBContext Init()
        {
            return dbContext ?? (dbContext = new PhuDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}