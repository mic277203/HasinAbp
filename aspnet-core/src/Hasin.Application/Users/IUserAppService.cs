using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Hasin.Roles.Dto;
using Hasin.Users.Dto;

namespace Hasin.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
