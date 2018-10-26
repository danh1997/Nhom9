using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HuflitBigPrj.MultiTenancy.Dto;

namespace HuflitBigPrj.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
