using System;
namespace Granite.data
{
    public static class DbInitializer
    {
        public static void Initialize(GraniteHouseContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
