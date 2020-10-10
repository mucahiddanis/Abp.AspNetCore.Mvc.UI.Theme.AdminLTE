using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Identity.Roles
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.CreateModalModel
    {
        public CreateModalModel(IIdentityRoleAppService identityRoleAppService) : base(identityRoleAppService)
        {
        }
    }
}