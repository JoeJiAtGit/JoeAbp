using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JoeAbp.Roles.Dto;
using JoeAbp.Users.Dto;

namespace JoeAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}