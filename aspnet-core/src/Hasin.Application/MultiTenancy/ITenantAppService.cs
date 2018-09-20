using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Hasin.MultiTenancy.Dto;

namespace Hasin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
