using System.Threading.Tasks;
using Abp.Application.Services;
using HuflitBigPrj.Authorization.Accounts.Dto;

namespace HuflitBigPrj.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
