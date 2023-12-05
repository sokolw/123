using System.Threading.Tasks;
using ABCCommunity.Configuration.Dto;

namespace ABCCommunity.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
