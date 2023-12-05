using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABCCommunity.Authorization.Roles;
using ABCCommunity.Authorization.Users;
using ABCCommunity.MultiTenancy;

namespace ABCCommunity.EntityFrameworkCore
{
    public class ABCCommunityDbContext : AbpZeroDbContext<Tenant, Role, User, ABCCommunityDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABCCommunityDbContext(DbContextOptions<ABCCommunityDbContext> options)
            : base(options)
        {
        }
    }
}
