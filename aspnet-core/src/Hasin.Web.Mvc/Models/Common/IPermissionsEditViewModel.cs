using System.Collections.Generic;
using Hasin.Roles.Dto;

namespace Hasin.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}