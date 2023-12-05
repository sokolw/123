using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABCCommunity.Configuration.Dto;

namespace ABCCommunity.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABCCommunityAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
