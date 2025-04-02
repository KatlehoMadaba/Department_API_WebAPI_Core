using Abp.Application.Services;
using MyFirstProj.Sessions.Dto;
using System.Threading.Tasks;

namespace MyFirstProj.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
