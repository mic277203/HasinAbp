using Abp.AutoMapper;
using Hasin.Roles.Dto;
using Hasin.Web.Models.Common;

namespace Hasin.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }

        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
