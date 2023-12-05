using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABCCommunity.EntityFrameworkCore
{
    public static class ABCCommunityDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABCCommunityDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABCCommunityDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
