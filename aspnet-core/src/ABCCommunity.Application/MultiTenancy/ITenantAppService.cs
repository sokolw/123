using Abp.Application.Services;
using ABCCommunity.MultiTenancy.Dto;

namespace ABCCommunity.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

