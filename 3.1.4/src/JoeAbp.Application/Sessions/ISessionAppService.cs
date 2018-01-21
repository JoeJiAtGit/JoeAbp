using System.Threading.Tasks;
using Abp.Application.Services;
using JoeAbp.Sessions.Dto;

namespace JoeAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
