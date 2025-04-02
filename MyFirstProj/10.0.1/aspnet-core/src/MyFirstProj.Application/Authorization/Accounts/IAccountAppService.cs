using Abp.Application.Services;
using MyFirstProj.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace MyFirstProj.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
