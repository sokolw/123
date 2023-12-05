using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABCCommunity.Configuration;

namespace ABCCommunity.Web.Host.Startup
{
    [DependsOn(
       typeof(ABCCommunityWebCoreModule))]
    public class ABCCommunityWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABCCommunityWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABCCommunityWebHostModule).GetAssembly());
        }
    }
}
