using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Identity.Web;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Identity
{
    public abstract class IdentityPageModel : AbpPageModel
    {
        protected IdentityPageModel()
        {
            ObjectMapperContext = typeof(AbpIdentityWebModule);
        }
    }
}
