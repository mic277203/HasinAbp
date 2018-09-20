using System.Collections.Generic;
using Hasin.Roles.Dto;
using Hasin.Users.Dto;

namespace Hasin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
