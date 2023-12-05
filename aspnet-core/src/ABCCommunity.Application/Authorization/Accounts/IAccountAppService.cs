using System.Threading.Tasks;
using Abp.Application.Services;
using ABCCommunity.Authorization.Accounts.Dto;

namespace ABCCommunity.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
