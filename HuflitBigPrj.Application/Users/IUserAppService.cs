using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HuflitBigPrj.Roles.Dto;
using HuflitBigPrj.Users.Dto;

namespace HuflitBigPrj.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}