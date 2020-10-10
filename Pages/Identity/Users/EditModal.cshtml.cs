using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Identity.Users
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.EditModalModel
    {
        public EditModalModel(IIdentityUserAppService identityUserAppService) : base(identityUserAppService)
        {
        }
    }
}
