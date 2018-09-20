using System.Threading.Tasks;
using Abp.Application.Services;
using Hasin.Sessions.Dto;

namespace Hasin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
