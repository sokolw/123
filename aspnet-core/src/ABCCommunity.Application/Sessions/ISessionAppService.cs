using System.Threading.Tasks;
using Abp.Application.Services;
using ABCCommunity.Sessions.Dto;

namespace ABCCommunity.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
