using System.Threading.Tasks;
using Abp.Application.Services;
using HuflitBigPrj.Sessions.Dto;

namespace HuflitBigPrj.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
