using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABCCommunity.EntityFrameworkCore;
using ABCCommunity.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABCCommunity.Web.Tests
{
    [DependsOn(
        typeof(ABCCommunityWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABCCommunityWebTestModule : AbpModule
    {
        public ABCCommunityWebTestModule(ABCCommunityEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABCCommunityWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABCCommunityWebMvcModule).Assembly);
        }
    }
}