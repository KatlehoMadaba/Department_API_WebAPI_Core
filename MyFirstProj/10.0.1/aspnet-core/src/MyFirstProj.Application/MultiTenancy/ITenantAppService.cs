using Abp.Application.Services;
using MyFirstProj.MultiTenancy.Dto;

namespace MyFirstProj.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

