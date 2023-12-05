using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABCCommunity.Authorization;

namespace ABCCommunity
{
    [DependsOn(
        typeof(ABCCommunityCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABCCommunityApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABCCommunityAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABCCommunityApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
