using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Identity.Users
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.CreateModalModel
    {
        public CreateModalModel(IIdentityUserAppService identityUserAppService) : base(identityUserAppService)
        {
        }
    }
}
