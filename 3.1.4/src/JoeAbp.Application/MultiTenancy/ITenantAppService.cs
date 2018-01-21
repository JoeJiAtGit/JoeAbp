using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JoeAbp.MultiTenancy.Dto;

namespace JoeAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
