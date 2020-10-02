using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants
{
    public class IndexModel : TenantManagementPageModel
    {
        public virtual Task<IActionResult> OnGetAsync()
        {
            return Task.FromResult<IActionResult>(Page());
        }

        public virtual Task<IActionResult> OnPostAsync()
        {
            return Task.FromResult<IActionResult>(Page());
        }
    }
}