using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class PasswordResetLinkSentModel : AccountPageModel
    {
        [BindProperty(SupportsGet = true)]
        public string ReturnUrl { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReturnUrlHash { get; set; }

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
